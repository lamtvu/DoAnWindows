using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GantChart.Models;
using GantChart.Controllers;
using GantChart.controll;
using System.Data.Entity.Core.Common.CommandTrees;

namespace GantChart.Views
{
    public partial class GantChartMain : Form
    {
        MyPanel myPanel;
        List<TaskWork> tasks;
        public Action<object, EventArgs> LabelClick;
        public GantChartMain()
        {
            InitializeComponent();
        }
        public void label_click(object sender, EventArgs e)
        {
            MyLabel myLabel = sender as MyLabel;

            this.txbTitle.Text = myLabel.Task.Title;
            this.dtpToDate.Value = myLabel.Task.ToDate;
            this.dtpFromDate.Value = myLabel.Task.FromDate;
            this.tbPercentCompleted.Text = myLabel.Task.PercentCompleted.ToString();
            this.tbDexcription.Text = myLabel.Task.description;
            this.cbbPriority.Text = myLabel.Task.Priority;
            this.lbID.Text = myLabel.Task.ID.ToString();
            this.rtbLink.Text = myLabel.Task.Url;
            lstUser.Items.Clear();
            foreach (User item in myLabel.Task.Users)
            {
                lstUser.Items.Add(item.UserName);
            }
        }
        private void from_Load(object sender, EventArgs e)
        {
            tasks = new List<TaskWork>();
            LabelClick = label_click;
            tasks = TaskController.GetListTask();
            this.Size = new Size(1300, 800);

            myPanel = new MyPanel(tasks, label_click, button1.Size.Width);

            splitContainer2.Panel2.Controls.Add(myPanel);
            myPanel.Dock = DockStyle.Fill;


            myPanel.BackColor = Color.White;
            UpdateCBBView();
            cbbView.SelectedItem = "ALL";

        }
        private void UpdateCBBView()
        {
            cbbView.Items.Clear();
            cbbView.Items.Add("ALL");
            foreach (User item in UserController.GetListUser())
            {
                cbbView.Items.Add(item.UserName);
            }
        }
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (myPanel == null)
            {
                return;
            }
            myPanel.PaintWidth = button1.Size.Width;
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (myPanel == null)
            {
                return;
            }
            myPanel.PaintWidth = button1.Size.Width;
        }
        private void btEditTask_Click(object sender, EventArgs e)
        {
            using (frmTask frmtask = new frmTask())
            {
                if (frmtask.ShowDialog() == DialogResult.OK)
                {
                    HienThi();

                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            using (frmUser frmuser = new frmUser())
            {
                if (frmuser.ShowDialog() == DialogResult.OK)
                {
                    //myPanel.ListTask = TaskController.GetListTask();
                    UpdateCBBView(); 
                    HienThi();
                }
            }
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            if (lbID.Text == "ID")
            {
                return;
            }
            if (!CheckInput.CheckInputAddTask(txbTitle, tbPercentCompleted, dtpFromDate, dtpToDate, cbbPriority, errorProvider1))
            {
                return;
            }
            TaskWork task = new TaskWork();

            task.ID = Convert.ToInt32(lbID.Text);
            task.description = tbDexcription.Text;
            task.Url = rtbLink.Text;
            task.Priority = cbbPriority.Text;
            task.Title = txbTitle.Text;
            task.ToDate = dtpToDate.Value;
            task.FromDate = dtpFromDate.Value;
            task.PercentCompleted = Convert.ToInt32(tbPercentCompleted.Text);
            task.Users = new List<User>();
            foreach (object item in lstUser.Items)
            {
                task.Users.Add(UserController.GetUser(item.ToString()));
            }
            TaskController.EditTask(task);
            //myPanel.ListTask = TaskController.GetListTask();
            HienThi();
            RefreshControll();
        }
        private void tbSearchUser_TextChanged(object sender, EventArgs e)
        {
            lstSearchUser.Items.Clear();
            TextBox tb = sender as TextBox;
            foreach (User item in UserController.GetListUser(tb.Text.Trim()))
            {
                lstSearchUser.Items.Add(item.UserName);
            }
        }
        private void lstSearchUser_DoubleClick(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox.SelectedItem == null)
            {
                return;
            }
            foreach (var item in lstUser.Items)
            {
                if (item.ToString()== listBox.SelectedItem.ToString())
                {
                    MessageBox.Show("User da ton tai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            lstUser.Items.Add(listBox.SelectedItem.ToString());
        }
        private void lstUser_DoubleClick(object sender, EventArgs e)
        {
            if (lstUser.SelectedItem == null )
            {
                return;
            }
            User user = UserController.GetUser(lstUser.SelectedItem.ToString());

            using (frmUser2 frm = new frmUser2(user.Email,user.FullName,user.UserName,user.Phone,ImageController.ConvertToImage(user.ImageUrl)))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (MessageBox.Show("Do you want to delete this user", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        lstUser.Items.Remove(lstUser.SelectedItem);
                    }
                }
                
            }
            
        }
        private void RefreshControll()
        {
            lbID.Text = "ID";
            txbTitle.Text = "";
            tbPercentCompleted.Text = "";
            tbSearchUser.Text = "";
            tbDexcription.Text = "";
            lstUser.Items.Clear();
            lstSearchUser.Items.Clear();
            cbbPriority.Text = "LOW";
            dtpFromDate.Value = DateTime.Now;
            dtpToDate.Value = DateTime.Now;
            rtbLink.Text = "";
        }
        private void rtbLink_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            var link = sender as RichTextBox;
            if (link.Text == "")
            {
                return;
            }
            System.Diagnostics.Process.Start(link.Text);
        }
        private void HienThi()
        {
            if (cbbView.Text == "" || cbbView.Text == "ALL")
            {
                myPanel.ListTask = TaskController.GetListTask();
                RefreshControll();

            }
            else
            {
                myPanel.ListTask = UserController.GetUser(cbbView.Text).Tasks.ToList();
                RefreshControll();

            }
        }

        private void cbbView_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).Text != "ALL" && (sender as ComboBox).Text != "")
            {
                myPanel.ListTask = UserController.GetUser(cbbView.Text).Tasks.ToList();
                RefreshControll();

            }
            else
            {
                myPanel.ListTask = TaskController.GetListTask();
                RefreshControll();

            }
        }
    }
}
