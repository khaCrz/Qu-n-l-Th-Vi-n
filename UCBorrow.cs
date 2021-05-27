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
    public partial class UCBorrow : UserControl
    {
        private static UCBorrow _Instance;
        public static UCBorrow Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new UCBorrow();
                }
                return _Instance;
            }
        }
        public UCBorrow()
        {
            InitializeComponent();
        }
        public void load()
        {
            GetCBB();
            dataGridView1.DataSource = BLL._Instance.GetAllBook();
        }
        public void GetCBB()
        {
            comboBox_loaisach.Items.Add(new CBBItems() { ID = 0, value = "All" });
            foreach (Category category in BLL._Instance.GetAllCategory())
            {
                comboBox_loaisach.Items.Add(new CBBItems() { ID = category.Category_ID, value = category.Category_type.Trim() });
            }
            comboBox_loaisach.SelectedItem = comboBox_loaisach.Items[0];
        }
    }
}
