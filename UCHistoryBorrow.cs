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
    public partial class UCHistoryBorrow : UserControl
    {
        private int _ID;

        private static UCHistoryBorrow _Instance;
        public static UCHistoryBorrow Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new UCHistoryBorrow();
                }
                return _Instance;
            }
        }
        public UCHistoryBorrow()
        {
            InitializeComponent();
        }
        public void load(int ID)
        {
            comboBox1.Items.Add("Ngày");
            comboBox1.SelectedItem = comboBox1.Items[0];
            _ID = ID;
            dataGridView1.DataSource = BLL._Instance.GetHitoryByID(_ID);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns.Add("Tên sách", "Tên sách");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1.Columns[1].Width.ToString() + " " + dataGridView1.Columns[2].Width.ToString() + " " + dataGridView1.Columns[3].Width.ToString()
                + " " + dataGridView1.Columns[4].Width.ToString() + " " + dataGridView1.Columns[5].Width.ToString());
        }
    }
}
