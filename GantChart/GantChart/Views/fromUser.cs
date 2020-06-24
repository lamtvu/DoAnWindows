using GantChart.Controllers;
using GantChart.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GantChart
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataUser.AllowUserToOrderColumns = false;
            dataUser.AllowUserToResizeColumns = false;
            cUserName.DataPropertyName = nameof(User.UserName);
            cFullName.DataPropertyName = nameof(User.FullName);
            cBirthDay.DataPropertyName = nameof(User.BirthDay);
            cPhone.DataPropertyName = nameof(User.Phone);
            cEmail.DataPropertyName = nameof(User.Email);
            RefreshControll();

            
        }
        private void btAddUser_Click(object sender, EventArgs e)
        {

            if (CheckInput.CheckInputAddUser(tbUsername,tbPhone,tbFullName,tbEmail,errorProvider1)==false)
            {
                return;
            }
            User user = new User();
            user.UserName = tbUsername.Text.Trim();
            user.FullName = tbFullName.Text.Trim();
            user.BirthDay = dtpBirthday.Value;
            user.Email = tbEmail.Text.Trim();
            user.Phone = tbPhone.Text.Trim();
            user.Tasks = new List<TaskWork>();
            user.ImageUrl = ImageController.ConvertToByteArray(pictureBox1.Image);
            UserController.AddUser(user);
            RefreshControll();

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataUser.SelectedRows.Count == 0)
            {
                return;
            }
            using (var _context = new DbGantChartContext())
            {
                for (int i = 0; i < dataUser.SelectedRows.Count; i++)
                {
                    string str = dataUser.SelectedRows[i].Cells["cUserName"].Value.ToString();
                    User user = _context.Users.Find(str);
                    UserController.DeleteUser(user);
                }
            }
            RefreshControll();


        }

        private void dataUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            tbUsername.Text = dataUser.Rows[e.RowIndex].Cells["cUserName"].Value.ToString();
            tbFullName.Text = dataUser.Rows[e.RowIndex].Cells["cFullName"].Value.ToString();
            dtpBirthday.Value = Convert.ToDateTime(dataUser.Rows[e.RowIndex].Cells["cBirthDay"].Value);
            tbPhone.Text = dataUser.Rows[e.RowIndex].Cells["cPhone"].Value.ToString();
            tbEmail.Text = dataUser.Rows[e.RowIndex].Cells["cEmail"].Value.ToString();
            if (UserController.GetUser(dataUser.Rows[e.RowIndex].Cells["cUserName"].Value.ToString()).ImageUrl !=null 
                && UserController.GetUser(dataUser.Rows[e.RowIndex].Cells["cUserName"].Value.ToString()).ImageUrl.Length>0)
            {
                pictureBox1.Image = ImageController.ConvertToImage(UserController.GetUser(dataUser.Rows[e.RowIndex].Cells["cUserName"].Value.ToString()).ImageUrl);
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            if(!CheckInput.CheckInputEditUser(tbUsername, tbPhone, tbFullName, tbEmail, errorProvider1))
            {
                return;
            }
            User user = new User();
            user.UserName = tbUsername.Text.Trim();
            user.FullName = tbFullName.Text.Trim();
            user.BirthDay = dtpBirthday.Value;
            user.Phone = tbPhone.Text;
            user.Email = tbEmail.Text;
            user.ImageUrl = ImageController.ConvertToByteArray(pictureBox1.Image);

            if (UserController.UpdateUser(user) == -1)
            {
                MessageBox.Show("username khong ton tai");
            }
            RefreshControll();
        }
        private void RefreshControll()
        {
            tbEmail.Text = "";
            tbFullName.Text = "";
            tbPhone.Text = "";
            tbUsername.Text = "";
            dtpBirthday.Value = DateTime.Now;
            dataUser.DataSource = (from u in UserController.GetListUser()
                                   select new { u.UserName, u.FullName, u.BirthDay, u.Phone, u.Email }).ToList();
            pictureBox1.Image = null;
        }
        private void btRefresh_Click(object sender, EventArgs e)
        {
            RefreshControll();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            using (frmSearchUser frmSearch = new frmSearchUser())
            {
                if (frmSearch.ShowDialog() == DialogResult.OK)
                {
                    dataUser.DataSource = (from u in ListController.GetListSearch(frmSearch.tbUserName.Text)
                                           select new { u.FullName, u.UserName, u.BirthDay, u.Email, u.Phone }).ToList();
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog() { Filter = "JPEG|*.jpg;*.png"})
            {
                if (opf.ShowDialog() ==DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(opf.FileName);
                }
            }
        }
        
    }
}
