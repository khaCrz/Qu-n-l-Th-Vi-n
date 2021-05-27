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
    public partial class UCHistoryAdmin : UserControl
    {

        private static UCHistoryAdmin _Instance;
        public static UCHistoryAdmin Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new UCHistoryAdmin();
                }
                return _Instance;
            }
        }
        public UCHistoryAdmin()
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
        }
    }
}
