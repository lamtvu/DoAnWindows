using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GantChart.Controllers
{
    class CheckInput
    {
        public static bool CheckInputAddUser(TextBox txbUserName, TextBox txbphone, TextBox txbfullname,TextBox txbEmail, ErrorProvider errorProvider)
        {
            errorProvider.Clear();
            bool k = true;
            if (txbfullname.Text == "")
            {
                k = false;
                errorProvider.SetError(txbfullname, "Khong duoc bo trong fullname");
            }
            if (txbUserName.Text == "")
            {
                k = false;
                errorProvider.SetError(txbUserName, "Khong duoc bo trong username");
            }
            else
            if (ChuaSpace(txbUserName.Text))
            {
                k = false;
                errorProvider.SetError(txbUserName, "user khong duoc chua khoan cach");
            }
            else
            if (UserController.GetUser(txbUserName.Text.Trim()) != null)
            {
                k = false;
                errorProvider.SetError(txbUserName, "user da ton tai");
            }
            if (!IsPhone(txbphone.Text))
            {
                k = false;
                errorProvider.SetError(txbphone, "Phone khong hop le");
            }
            if (!IsEmail(txbEmail.Text))
            {
                k = false;
                errorProvider.SetError(txbEmail, "Email khong hop le");

            }
            return k;
        }
        public static bool CheckInputEditUser(TextBox txbUserName, TextBox txbphone, TextBox txbfullname, TextBox txbEmail, ErrorProvider errorProvider)
        {
            errorProvider.Clear();
            bool k = true;
            if (txbfullname.Text == "")
            {
                k = false;
                errorProvider.SetError(txbfullname, "Khong duoc bo trong fullname");
            }
            if (txbUserName.Text == "")
            {
                k = false;
                errorProvider.SetError(txbUserName, "Khong duoc bo trong username");
            }
            else
            if (ChuaSpace(txbUserName.Text))
            {
                k = false;
                errorProvider.SetError(txbUserName, "user khong duoc chua khoan cach");
            }
            else
            if (UserController.GetUser(txbUserName.Text.Trim()) == null)
            {
                k = false;
                errorProvider.SetError(txbUserName, "user khong ton tai");
            }
            if (!IsPhone(txbphone.Text))
            {
                k = false;
                errorProvider.SetError(txbphone, "Phone khong hop le");
            }
            if (!IsEmail(txbEmail.Text))
            {
                k = false;
                errorProvider.SetError(txbEmail, "Email khong hop le");

            }
            return k;
        }

        public static bool CheckInputAddTask(TextBox title,TextBox Percent,DateTimePicker fdate,DateTimePicker tdate, ComboBox priority, ErrorProvider errorProvider)
        {
            bool k = true;
            errorProvider.Clear();
            if (title.Text == "")
            {
                k = false;
                errorProvider.SetError(title, "Khong duoc bo trong title");
            }
            if (!IsNumber(Percent.Text)||Convert.ToInt32(Percent.Text)>100)
            {
                k = false;
                errorProvider.SetError(Percent, "percent la so nguyen <100 && >0");
            }
            if (fdate.Value>=tdate.Value)
            {
                k = false;
                errorProvider.SetError(tdate, "To Date phai lon hon From Date");
            }
            if (priority.Text=="")
            {
                k = false;
                errorProvider.SetError(priority, "Khong duoc bo trong priority");
            }
            return k;
        }
        private static bool IsPhone(string pText)
        {
            Regex regex = new Regex(@"^[0-9]{9,10}$");
            return regex.IsMatch(pText);
        }
        private static bool IsNumber(string text)
        {
            Regex regex = new Regex(@"^[0-9]{1,10}$");
            return regex.IsMatch(text);
        }
        private static bool ChuaSpace(string str)
        {
            foreach (char item in str)
            {
                if (item == ' ')
                {
                    return true;
                }
            }
            return false;
        }
        private static bool IsEmail(string str)
        {
            Regex regex = new Regex(@"^[a-zA-Z][a-zA-Z0-9_\.]{3,32}@gmail.com$");
            return regex.IsMatch(str);
        }
    }
}