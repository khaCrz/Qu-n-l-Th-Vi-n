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
            List<Class_Book> listbook = new List<Class_Book>();
            foreach (Book book in BLL._Instance.GetAllBook())
            {
                Class_Book book1 = new Class_Book();
                book1.Book_ID = book.Book_ID;
                book1.Name = book.Name.Trim();
                book1.Published_Year = book.Published_Year;
                book1.Language = book.Language.Trim();
                book1.Amount = book.Amount;
                foreach (Category item in BLL._Instance.GetAllCategory())
                {
                    if (item.Category_ID == book.Category_ID)
                        book1.Category = item.Category_type.Trim();
                }
                foreach (Stock item in BLL._Instance.GetAllStock())
                {
                    if (item.Stock_ID == book.Stock_ID)
                        book1.Stock = item.Stock_KV.Trim();
                }
                listbook.Add(book1);
            }
            dataGridView1.DataSource = listbook;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[1].Width = 380;
            dataGridView1.Columns[2].Width = 105;
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[4].Width = 79;
            dataGridView1.Columns[5].Width = 122;
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

        private void comboBox_loaisach_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Class_Book> listbook = new List<Class_Book>();
            foreach (Book book in BLL._Instance.GetBookByCategoryID((comboBox_loaisach.SelectedItem as CBBItems).ID))
            {
                Class_Book book1 = new Class_Book();
                book1.Book_ID = book.Book_ID;
                book1.Name = book.Name.Trim();
                book1.Published_Year = book.Published_Year;
                book1.Language = book.Language.Trim();
                book1.Amount = book.Amount;
                foreach (Category item in BLL._Instance.GetAllCategory())
                {
                    if (item.Category_ID == book.Category_ID)
                        book1.Category = item.Category_type.Trim();
                }
                foreach (Stock item in BLL._Instance.GetAllStock())
                {
                    if (item.Stock_ID == book.Stock_ID)
                        book1.Stock = item.Stock_KV.Trim();
                }
                listbook.Add(book1);
            }
            dataGridView1.DataSource = listbook;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[1].Width = 380;
            dataGridView1.Columns[2].Width = 105;
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[4].Width = 79;
            dataGridView1.Columns[5].Width = 122;
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            if (textBox_search.Text.Trim() != "")
            {
                dataGridView1.DataSource = null;
                List<Class_Book> listbook = new List<Class_Book>();
                foreach (Book book in BLL._Instance.Search(BLL._Instance.GetAllBook(), textBox_search.Text.ToLower(), (comboBox_loaisach.SelectedItem as CBBItems).ID))
                {
                    Class_Book book1 = new Class_Book();
                    book1.Book_ID = book.Book_ID;
                    book1.Name = book.Name.Trim();
                    book1.Published_Year = book.Published_Year;
                    book1.Language = book.Language.Trim();
                    book1.Amount = book.Amount;
                    foreach (Category item in BLL._Instance.GetAllCategory())
                    {
                        if (item.Category_ID == book.Category_ID)
                            book1.Category = item.Category_type.Trim();
                    }
                    foreach (Stock item in BLL._Instance.GetAllStock())
                    {
                        if (item.Stock_ID == book.Stock_ID)
                            book1.Stock = item.Stock_KV.Trim();
                    }
                    listbook.Add(book1);
                }
                dataGridView1.DataSource = listbook;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[1].Width = 380;
                dataGridView1.Columns[2].Width = 105;
                dataGridView1.Columns[3].Width = 90;
                dataGridView1.Columns[4].Width = 79;
                dataGridView1.Columns[5].Width = 122;
            }
            else
            {
                List<Class_Book> listbook = new List<Class_Book>();
                foreach (Book book in BLL._Instance.GetAllBook())
                {
                    Class_Book book1 = new Class_Book();
                    book1.Book_ID = book.Book_ID;
                    book1.Name = book.Name.Trim();
                    book1.Published_Year = book.Published_Year;
                    book1.Language = book.Language.Trim();
                    book1.Amount = book.Amount;
                    foreach (Category item in BLL._Instance.GetAllCategory())
                    {
                        if (item.Category_ID == book.Category_ID)
                            book1.Category = item.Category_type.Trim();
                    }
                    foreach (Stock item in BLL._Instance.GetAllStock())
                    {
                        if (item.Stock_ID == book.Stock_ID)
                            book1.Stock = item.Stock_KV.Trim();
                    }
                    listbook.Add(book1);
                }
                dataGridView1.DataSource = listbook;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[1].Width = 380;
                dataGridView1.Columns[2].Width = 105;
                dataGridView1.Columns[3].Width = 90;
                dataGridView1.Columns[4].Width = 79;
                dataGridView1.Columns[5].Width = 122;
            }
        }
    }
}
