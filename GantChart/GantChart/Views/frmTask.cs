using GantChart.Controllers;
using GantChart.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GantChart.Views
{
    public partial class frmTask : Form
    {
        
        public frmTask()
        {
            InitializeComponent();
        }

        private void frmTask_Load(object sender, EventArgs e)
        {
            cmbPriority.SelectedItem = "LOW";
            dataTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataTasks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //dataTasks.DataSource = TaskController.GetListTask();
            HienThi(TaskController.GetListTask());
        }
        private void HienThi(List<TaskWork> listTask)
        {
            dataTasks.Rows.Clear();
            foreach (var item in listTask)
            {
                dataTasks.Rows.Add(item.ID,item.Title, item.description,item.Priority, item.ToDate.ToString(), item.FromDate.ToString(), item.PercentCompleted.ToString(), item.GetUsers());
            }
            errorProvider1.Clear();
            lbID.Text = "ID";
            tbTitle.Text = "";
            tbDescription.Text = "";
            tbPercentCompleted.Text = "";
            rtbLink.Text = "";
            dtpFDate.Value = DateTime.Now;
            dtpTDate.Value = DateTime.Now;
            lsbUsers.Items.Clear();
            cmbPriority.Text = "LOW";

        }
        private void tbAdd_Click(object sender, EventArgs e)
        {
            if (!CheckInput.CheckInputAddTask(tbTitle, tbPercentCompleted, dtpFDate, dtpTDate, cmbPriority,errorProvider1))
            {
                return;
            }
            TaskWork taskWork = new TaskWork();
            taskWork.Title = tbTitle.Text;
            taskWork.Priority = cmbPriority.Text;
            taskWork.Url = rtbLink.Text;
            taskWork.description = tbDescription.Text;
            taskWork.FromDate = dtpFDate.Value;
            taskWork.ToDate = dtpTDate.Value;
            taskWork.PercentCompleted = Convert.ToInt32(tbPercentCompleted.Text);
            taskWork.Users = new List<User>();
            foreach (Object item in lsbUsers.Items)
            {
                taskWork.Users.Add(UserController.GetUser(item.ToString()));
            }
            TaskController.AddTask(taskWork);
            HienThi(TaskController.GetListTask());

        }
        private void tbSearchUser_TextChanged(object sender, EventArgs e)
        {

            lbSearchUser.Items.Clear();
            TextBox tb = sender as TextBox;
            foreach (User item in UserController.GetListUser(tb.Text.Trim()))
            {
                lbSearchUser.Items.Add(item.UserName);
            }
        }
        private void lbSearchUser_DoubleClick(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox.SelectedItem == null)
            {
                return;
            }
            foreach (var item in lsbUsers.Items)
            {
                if (item.ToString() == listBox.SelectedItem.ToString())
                {
                    MessageBox.Show("User da ton tai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            lsbUsers.Items.Add(listBox.SelectedItem.ToString());

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if(dataTasks.SelectedRows.Count == 0)
            {
                return;
            }
            using (var _context = new DbGantChartContext())
            {
                for (int i = 0; i < dataTasks.SelectedRows.Count; i++)
                {
                    TaskController.DeleteTask(Convert.ToInt32(dataTasks.SelectedRows[i].Cells["cId"].Value));
                }
                
            }
            HienThi(TaskController.GetListTask());

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (lbID.Text=="ID")
            {
                return;
            }
            if (!CheckInput.CheckInputAddTask(tbTitle, tbPercentCompleted, dtpFDate, dtpTDate, cmbPriority, errorProvider1))
            {
                return;
            }
            TaskWork task = new TaskWork();

            task.ID = Convert.ToInt32(lbID.Text);
            task.description = tbDescription.Text;
            task.Url = rtbLink.Text;
            task.Priority = cmbPriority.Text;
            task.Title = tbTitle.Text;
            task.ToDate = dtpTDate.Value;
            task.FromDate = dtpFDate.Value;
            task.PercentCompleted =Convert.ToInt32(tbPercentCompleted.Text);
            task.Users = new List<User>();
            foreach (object item in lsbUsers.Items)
            {
                task.Users.Add(UserController.GetUser(item.ToString()));
            }
            TaskController.EditTask(task);
            HienThi(TaskController.GetListTask());
        }
        private void dataTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0)
            {
                return;
            }
            lsbUsers.Items.Clear();
            TaskWork task = TaskController.GetTask(Convert.ToInt32(dataTasks.Rows[e.RowIndex].Cells["cId"].Value));
            lbID.Text = task.ID.ToString();
            tbTitle.Text = task.Title;
            tbDescription.Text = task.description;
            tbPercentCompleted.Text = task.PercentCompleted.ToString();
            dtpFDate.Value = task.FromDate;
            dtpTDate.Value = task.ToDate;
            rtbLink.Text = task.Url;
            cmbPriority.Text = task.Priority;
            foreach (User item in task.Users)
            {
                lsbUsers.Items.Add(item.UserName);
            }
        }

        private void lsbUsers_DoubleClick(object sender, EventArgs e)
        {
            if (lsbUsers.SelectedItem == null)
            {
                return;
            }
            if (MessageBox.Show("Do you want to delete this user", "Question", MessageBoxButtons.YesNo,MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                lsbUsers.Items.Remove(lsbUsers.SelectedItem);
            }
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

        private void btRefresh_Click(object sender, EventArgs e)
        {
            HienThi(TaskController.GetListTask());

        }
    }
}
