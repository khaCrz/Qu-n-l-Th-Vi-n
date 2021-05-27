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
    public partial class Form1 : Form
    {
        public readonly bool Form_ADMIN = true;

        public readonly bool Form_Member = false;
        private static bool CheckForm = false;
        private int _ID = 0;
        static bool checklogin = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_thuviensach_Click(object sender, EventArgs e)
        {
            if (checklogin == true)
            {
                if (!panel3.Controls.Contains(UCThuVienSach.Instance))
                {
                    panel3.Controls.Add(UCThuVienSach.Instance);
                    UCThuVienSach.Instance.Dock = DockStyle.Fill;
                    UCThuVienSach.Instance.BringToFront();
                }
                else
                {
                    UCThuVienSach.Instance.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("Chưa đăng nhập");
            }
        }

        private void button_thongtincanhan_Click(object sender, EventArgs e)
        {
            if (checklogin == true)
            {
                UCThongTinCaNhan.Instance.GetID(_ID);
                if (!panel3.Controls.Contains(UCThongTinCaNhan.Instance))
                {
                    panel3.Controls.Add(UCThongTinCaNhan.Instance);
                    UCThongTinCaNhan.Instance.Dock = DockStyle.Fill;
                    UCThongTinCaNhan.Instance.BringToFront();
                }
                else
                {
                    UCThongTinCaNhan.Instance.BringToFront();
                }
            }
            else
                MessageBox.Show("Chưa đăng nhập");
        }

        private void button_lichsumuotra_Click(object sender, EventArgs e)
        {
            if (checklogin == true)
            {
                if (!panel3.Controls.Contains(UCHistoryBorrow.Instance))
                {
                    UCHistoryBorrow.Instance.load(_ID);
                    panel3.Controls.Add(UCHistoryBorrow.Instance);
                    UCHistoryBorrow.Instance.Dock = DockStyle.Fill;
                    UCHistoryBorrow.Instance.BringToFront();
                }
                else
                {
                    UCHistoryBorrow.Instance.BringToFront();
                }
            }
            else
                MessageBox.Show("Chưa đăng nhập");
        }

        private void button_muon_Click(object sender, EventArgs e)
        {
            if (checklogin == true)
            {
                if (!panel3.Controls.Contains(UCBorrow.Instance))
                {
                    panel3.Controls.Add(UCBorrow.Instance);
                    UCBorrow.Instance.Dock = DockStyle.Fill;
                    UCBorrow.Instance.BringToFront();
                }
                else
                {
                    UCBorrow.Instance.BringToFront();
                }
            }
            else
                MessageBox.Show("Chưa đăng nhập");
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (checklogin == false)
            {
                if (!panel3.Controls.Contains(UCMainlogin.Instance))
                {
                    panel3.Controls.Add(UCMainlogin.Instance);
                    UCMainlogin.Instance.MyDel = new UCMainlogin.del(load);
                    UCMainlogin.Instance.Dock = DockStyle.Fill;
                    UCMainlogin.Instance.BringToFront();
                }
                else
                {
                    UCMainlogin.Instance.BringToFront();
                }
            }
            else
            {
                if (!panel3.Controls.Contains(UCLogout.Instance))
                {
                    panel3.Controls.Add(UCLogout.Instance);
                    UCLogout.Instance.Dock = DockStyle.Fill;
                    UCLogout.Instance.BringToFront();
                }
                else
                {
                    UCLogout.Instance.BringToFront();
                }
            }
        }

        public void load(int ID)
        {
            _ID = ID;
            checklogin = true;
            CheckForm = BLL._Instance.GetFormByID(_ID);
            object sender = null;
            EventArgs e = null;
            button_thuviensach_Click(sender, e);

        }
    }
}
