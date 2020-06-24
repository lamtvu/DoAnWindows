using GantChart.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GantChart.Views
{
    public partial class frmUser2 : Form
    {
        public frmUser2()
        {
            
            InitializeComponent();
        }
        public frmUser2(string Email,string FullName,string UserName,string Phone,Image image)
        {
            InitializeComponent();
            tbEmail.Text = Email;
            tbFullname.Text = FullName;
            tbUsername.Text = UserName;
            tbPhone.Text = Phone;
            pictureBox1.Image = image;
        }
    }
}
