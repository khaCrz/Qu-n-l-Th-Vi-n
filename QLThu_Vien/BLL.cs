using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThu_Vien1
{
    class BLL
    {
        private static BLL Instance;

        public static BLL _Instance
        {
            get
            {
                if (Instance == null)
                    Instance = new BLL();
                return Instance;
            }
            set => Instance = value;
        }

        private BLL() { }

        public bool CheckLogin(string textBox_username, string textBox_password)
        {
            return DAL._Instance.CheckLogin(textBox_username, textBox_password);
        }

        public int GetID(string textBox_username)
        {
            return DAL._Instance.GetID(textBox_username);
        }

        public bool GetFormByID(int ID)
        {
            return DAL._Instance.GetFormByID(ID);
        }

        public Member GetMemberByID(int ID)
        {
            return DAL._Instance.GetMemberByID(ID); 
        }

        public List<Book> GetAllBook()
        {
            return DAL._Instance.GetAllBook();
        }

        public List<Category> GetAllCategory()
        {
            return DAL._Instance.GetAllCategory();
        }

        public List<Book> GetBookByCategoryID(int ID)
        {
            if (ID == 0)
                return DAL._Instance.GetAllBook();
            else
                return DAL._Instance.GetBookByCategoryID(ID);
        }

        public List<Book> Search(List<Book> listbooks, string namebook)
        {
            return DAL._Instance.Search(listbooks, namebook);
        }

        public void Editmember(Member man)
        {
            DAL._Instance.EditMember(man);
        }

        public List<Manager> GetAllHistory()
        {
            return DAL._Instance.GetAllHistory();
        }

        public List<Manager> GetHitoryByID(int ID)
        {
            return DAL._Instance.GetHistoryBYID(ID);
        }
    }
}
