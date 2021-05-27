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
    public partial class UCThuVienSach : UserControl
    {
        private static UCThuVienSach _Instance;
        public static UCThuVienSach Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new UCThuVienSach();
                }
                return _Instance;
            }
        }
        public UCThuVienSach()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            GetCBB();
            dataGridView1.DataSource = BLL._Instance.GetAllBook();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[1].Width = 500;
            dataGridView1.Columns[2].Width = 138;
            dataGridView1.Columns[3].Width = 138;
        }
        
        public void GetCBB()
        {
            comboBox_loaisach.Items.Add(new CBBItems() { ID = 0 , value = "All"});
            foreach (Category category in BLL._Instance.GetAllCategory())
            {
                comboBox_loaisach.Items.Add(new CBBItems() { ID = category.Category_ID, value = category.Category_type.Trim() });
            }
            comboBox_loaisach.SelectedItem = comboBox_loaisach.Items[0];
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (textBox_search.Text.Trim() != "")
            {
                List<Book> listbooks = dataGridView1.DataSource as List<Book>;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = BLL._Instance.Search(listbooks, textBox_search.Text.ToLower());
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[1].Width = 500;
                dataGridView1.Columns[2].Width = 138;
                dataGridView1.Columns[3].Width = 138;
            }
        }

        private void comboBox_loaisach_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL._Instance.GetBookByCategoryID((comboBox_loaisach.SelectedItem as CBBItems).ID);
        }
    }
}
