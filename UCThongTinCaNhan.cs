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
    public partial class UCThongTinCaNhan : UserControl
    {
        private int _ID;
        private static UCThongTinCaNhan _Instance;
        public static UCThongTinCaNhan Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new UCThongTinCaNhan();
                }
                return _Instance;
            }
        }
        public UCThongTinCaNhan()
        {
            InitializeComponent();
        }
        public void GetID(int ID)
        {
            _ID = ID;
            Member member = BLL._Instance.GetMemberByID(ID);
            label_Name.Text = member.Name.Trim();
            label_Gender.Text = member.Gender.Trim();
            label_CMND.Text = member.CMND.Trim();
            label_Email.Text = member.Email.Trim();
            label_NS.Text = member.NS.Value.ToShortDateString();
            label_Phone.Text = member.Phone.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_DesignInfor FD = new Form_DesignInfor(_ID);
            FD.FormClosed += close;
        }
        public void close(object sender, EventArgs e)
        {
            GetID(_ID);
        }
    }
}
