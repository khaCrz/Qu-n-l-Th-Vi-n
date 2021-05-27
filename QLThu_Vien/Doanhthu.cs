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
    public partial class Doanhthu : Form
    {
        public Doanhthu()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            dataGridView1.DataSource = BLL._Instance.GetAllHistory();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            double? count = 0;
            foreach(Manager i in BLL._Instance.GetAllHistory().ToList())
            {
                count += i.Amount;
            }
            label2.Text = count.ToString();

    }
}
}

