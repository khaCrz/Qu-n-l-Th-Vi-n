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
        public void GetCBB()
        {
            comboBox1.Items.Add("Ngày Mượn");
            comboBox1.Items.Add("Ngày Trả");
            comboBox1.Items.Add("Tên sách");
            comboBox1.Items.Add("Giá tiền");
            comboBox1.SelectedItem = comboBox1.Items[0];
        }
        public void load(int ID)
        {
            List<Class_HistoryBorrow> listHistory = new List<Class_HistoryBorrow>();
            foreach (Manager History in BLL._Instance.GetHitoryByID(ID))
            {
                Class_HistoryBorrow history = new Class_HistoryBorrow();
                history.Book_ID = History.Book_ID;
                foreach (Book book in BLL._Instance.GetAllBook())
                {
                    if (book.Book_ID == History.Book_ID)
                        history.Book_Name = book.Name.Trim();
                }
                history.Amount = History.Amount ?? default(double);
                history.Date_Time_Borrowed = History.Date_Time_Borrowed ?? default(DateTime);
                history.Date_Time_Returned = History.Date_Time_Returned ?? default(DateTime);
                history.Manager_ID = History.Manager_ID;
                history.Member_ID = History.Member_ID;
                foreach (Member member in BLL._Instance.GetAllMember())
                {
                    if (member.Member_ID == history.Member_ID)
                        history.Member_Name = member.Name;
                }
                listHistory.Add(history);
            }
            dataGridView1.DataSource = listHistory;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Width = 216;
            dataGridView1.Columns[4].Width = 157;
            dataGridView1.Columns[5].Width = 165;
            dataGridView1.Columns[6].Width = 139;
            dataGridView1.Columns[7].Width = 121;
            GetCBB();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Class_HistoryBorrow> listHistory = new List<Class_HistoryBorrow>();
            listHistory = dataGridView1.DataSource as List<Class_HistoryBorrow>;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BLL._Instance.GetListSort(listHistory, comboBox1.SelectedItem.ToString());
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Width = 216;
            dataGridView1.Columns[4].Width = 157;
            dataGridView1.Columns[5].Width = 165;
            dataGridView1.Columns[6].Width = 139;
            dataGridView1.Columns[7].Width = 121;
        }
    }
}
