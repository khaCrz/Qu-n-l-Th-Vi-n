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
    public partial class Form_DesignInfor : Form
    {
        private int _ID;
        public Form_DesignInfor(int ID)
        {
            InitializeComponent();
            _ID = ID;
            load(ID);
        }

        public void load(int ID)
        {
            Member man = new Member(); 
            man = BLL._Instance.GetMemberByID(ID);
            textBox_Name.Text = man.Name.Trim();
            textBox_CMND.Text = man.CMND.Trim();
            textBox_Email.Text = man.Email.Trim();
            textBox_Phone.Text = man.Phone.ToString();
            if (man.Gender.Trim() == "Nam")
                radioButton_Male.Checked = true;
            else
                radioButton_Female.Checked = true;
            dateTimePicker1.Value = Convert.ToDateTime(man.NS.Value.ToShortDateString());
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if(textBox_CMND.Text == "" || textBox_Email.Text == "" || textBox_Name.Text == "" || textBox_Phone.Text == "")
            {
                MessageBox.Show("!!!");
                return;
            }
            Member man = new Member();
            man.Name = textBox_Name.Text;
            man.NS = dateTimePicker1.Value;
            man.Phone = Convert.ToInt32(textBox_Phone.Text);
            man.Email = textBox_Email.Text;
            if (radioButton_Male.Checked == true)
                man.Gender = "Nam";
            else
                man.Gender = "Nữ";
            man.Member_ID = _ID;
            BLL._Instance.Editmember(man);
        }
    }
}
