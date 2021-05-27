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
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            dataGridView1.DataSource = BLL._Instance.GetAllMember();
        }
    }
}
