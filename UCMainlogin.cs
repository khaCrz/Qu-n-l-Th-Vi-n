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
    public partial class UCMainlogin : UserControl
    {
        public delegate void del(int id);
        public del MyDel { get; set; }

        private bool checke = false;

        private static UCMainlogin _Instance;
        public static UCMainlogin Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new UCMainlogin();
                }
                return _Instance;
            }
        }
        public UCMainlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checke = BLL._Instance.CheckLogin(textBox_username.Text, textBox_password.Text);
            if (checke == true)
                MyDel.Invoke(BLL._Instance.GetID(textBox_username.Text));
            else
            {
                MessageBox.Show("user or pass sai!!");
            }
        }
    }
}
