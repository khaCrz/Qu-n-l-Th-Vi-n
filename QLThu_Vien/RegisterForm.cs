using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThu_Vien1
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox_username.Text.Trim() == "" && textBox_password.Text.Trim() == "" && textBox_passwordConfirm.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin");
            }
            User newuser = new User();
            newuser.User_ID = BLL._Instance.GetNewIDUser();
            newuser.User_name = textBox_username.Text.Trim();
            newuser.Password = textBox_password.Text.Trim();
            newuser.User_Type = "User";
            BLL._Instance.AddUser(newuser);
            Form_DesignInfor FD = new Form_DesignInfor(0);
            FD.GetIDUser(newuser.User_ID);
            FD.Show();
            FD.FormClosed += close;

        }

        public void close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
