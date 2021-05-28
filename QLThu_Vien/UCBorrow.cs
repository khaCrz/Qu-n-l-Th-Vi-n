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
        private int _ID = 0;
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
        public void GetID(int ID)
        {
            _ID = ID;
        }
        public UCBorrow()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            GetCBB();
            List<int> listID = new List<int>();
            foreach (Manager item in BLL._Instance.GetAllHistory())
            {
                if (item.Date_Time_Returned.Value.ToShortDateString().CompareTo(DateTime.Now.ToShortDateString()) > 0)
                {
                    listID.Add(item.Book_ID ?? default(int));
                }
            }
            List<Class_Book> listbook = new List<Class_Book>();
            foreach (Book book in BLL._Instance.GetAllBook())
            {
                if (!listID.Contains(book.Book_ID))
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
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listbook;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[1].Width = 380;
            dataGridView1.Columns[2].Width = 110;
            dataGridView1.Columns[3].Width = 92;
            dataGridView1.Columns[4].Width = 82;
            dataGridView1.Columns[5].Width = 130;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                List<int> listID = new List<int>();
                foreach (Manager item in BLL._Instance.GetAllHistory())
                {
                    if (item.Date_Time_Returned.Value.ToShortDateString().CompareTo(DateTime.Now.ToShortDateString()) > 0)
                    {
                        listID.Add(item.Book_ID ?? default(int));
                    }
                }
                dataGridView1.DataSource = null;
                List<Class_Book> listbook = new List<Class_Book>();
                foreach (Book book in BLL._Instance.Search(BLL._Instance.GetAllBook(), textBox1.Text.ToLower(), (comboBox_loaisach.SelectedItem as CBBItems).ID))
                {
                    if (!listID.Contains(book.Book_ID))
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

        private void button_add_Click(object sender, EventArgs e)
        {
            double total = 0;
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count > 0)
            {
                if (dateTimePicker_tra.Value.ToShortDateString().CompareTo(dateTimePicker_muon.Value.ToShortDateString()) < 0)
                {
                    MessageBox.Show("Ngày mượn phải lớn hơn ngày trả");
                    return;
                }
                foreach (DataGridViewRow item in r)
                {
                    Manager history = new Manager();
                    history.Book_ID = (int)item.Cells[0].Value;
                    history.Amount = (double)item.Cells[6].Value;
                    history.Date_Time_Borrowed = dateTimePicker_muon.Value;
                    history.Date_Time_Returned = dateTimePicker_tra.Value;
                    history.Member_ID = _ID;
                    history.Manager_ID = BLL._Instance.GetNewIDManager();
                    total += (double)item.Cells[6].Value;
                    BLL._Instance.AddHistory(history);
                }
                MessageBox.Show("Yêu cầu mượn sách thành công .Vui lòng mang số tiền kèm CMND đến quầy để thanh toán!\n" + " Tổng số tiền : " + total.ToString());
                load();
            }
            else
            {
                MessageBox.Show("Chưa chọn sách!!");
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
