using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThu_Vien1
{
    class DAL
    {
        private static DAL Instance;
        private QLThu_VienEntities db;
        public static DAL _Instance
        {
            get
            {
                if (Instance == null)
                    Instance = new DAL();
                return Instance;
            }
            set => Instance = value;
        }

        private DAL()
        {
            db = new QLThu_VienEntities();
        }

        public bool CheckLogin(string textBox_username, string textBox_password)
        {
            foreach (User item in db.Users.Select(p => p).ToList())
            {
                if(item.User_name.Trim() == textBox_username)
                {
                    if (item.Password.Trim() == textBox_password)
                        return true;
                }
            }
            return false;
        }

        public bool GetFormByID(int ID)
        {
            bool form = false;
            foreach (User item in db.Users.Select(p => p).ToList())
            {
                if (item.User_ID == ID)
                {
                    if (item.User_Type.Trim() == "Admin")
                        form = true;
                    else
                        form = false;
                }
            }
            return form;
        }

        public List<Member> GetAllMember()
        {
            List<Member> listmember = new List<Member>();
            listmember = db.Members.Select(p => p).ToList();
            return listmember;
        }

        internal Member GetMemberByID(int ID)
        {
            Member man = new Member();
            foreach (Member item in GetAllMember())
            {
                if (item.Member_ID == ID)
                    man = item;
            }
            return man;
        }

        public List<Manager> GetAllHistory()
        {
            List<Manager> listmember = new List<Manager>();
            listmember = db.Managers.Select(p => p).ToList();
            return listmember;
        }

        internal List<Manager> GetHistoryBYID(int iD)
        {
            List<Manager> l = new List<Manager>();
            foreach (Manager item in GetAllHistory())
            {
                if (item.Member_ID == iD)
                    l.Add(item);
            }
            return l;
        }

        public void EditMember(Member man)
        {
            Member man1 = db.Members.Where(p => p.Member_ID == man.Member_ID).Single();
            man1.Name = man.Name;
            man1.NS = man.NS;
            man1.Phone = man.Phone;
            man1.Email = man.Email;
            man1.CMND = man.CMND;
            db.SaveChanges();
        }

        public List<Book> GetBookByCategoryID(int ID)
        {
            List<Book> listbook = new List<Book>();
            foreach (Book book in db.Books.Select(p => p).ToList())
            {
                if (book.Category_ID == ID)
                    listbook.Add(book);
            }
            return listbook;
        }

        public List<Book> Search(List<Book> listbooks, string namebook)
        {
            List<Book> listsach = new List<Book>();
            foreach (Book book in listbooks)
            {
                if (book.Name.Trim().ToLower().Contains(namebook))
                    listsach.Add(book);
            }
            return listsach;
        }

        public List<Category> GetAllCategory()
        {
            List<Category> listcategory = new List<Category>();
            listcategory = db.Categories.Select(p => p).ToList();
            return listcategory;
        }

        public List<Book> GetAllBook()
        {
            List<Book> listbook = new List<Book>();
            listbook = db.Books.Select(p => p).ToList();
            return listbook;
        }

        public int GetID(string textBox_username)
        {
            int ID = 0;
            foreach (User item in db.Users.Select(p => p).ToList())
            {
                if (item.User_name.Trim() == textBox_username)
                {
                    ID = item.User_ID;
                }
            }
            return ID;
        }
    }
}
