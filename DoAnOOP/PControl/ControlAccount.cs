using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnOOP.PControl
{
    internal class ControlAccount
    {
        public static doAnEntities db = ControlDataBase.qlhocvien;
        private static Account account;

        public static Account Account { get => account; set => account = value; }

        public static List<Account> FindAll()
        {
            var aList = from s in db.Accounts select s;
            return aList.ToList();
        }

        public static bool Login(string uName, string password)
        {
            bool result = false;
            FindAll().ForEach(a =>
            {
                if (a.UserName == uName && a.Password == password)
                    result = true;
            });
            return result;
        }

        public static Account DefineAcc(string acc)
        {
            try
            {
                return db.Accounts.Find(int.Parse(acc));
            }
            catch 
            {
                return db.Accounts.Find(int.Parse("1"));
            }
        }

        public static void Add(Account acc)
        {
            try
            {
                db.Accounts.Add(acc);
                db.SaveChanges();
                MessageBox.Show("Them Account Thanh Cong");
            }
            catch 
            {
                MessageBox.Show("Them Account That Bai");
            }
        }

        public static void Delete(Account acc)
        {
            try
            {
                db.Accounts.Remove(acc);
                db.SaveChanges();
                MessageBox.Show("Xoa thanh cong");
            }
            catch 
            {
                MessageBox.Show("Xoa khong thanh cong");
            }
        }

        public static void Update(Account acc)
        {
            try
            {
                db.Accounts.AddOrUpdate(acc);
                db.SaveChanges();
                MessageBox.Show("Cap nhat thanh cong");
            }
            catch 
            {
                MessageBox.Show("Cap nhat khong thanh cong");
            } 

        }

        public static List<Account> AccountSearching(string search)
        {
            List<Account> listUName = (from s in FindAll().ToList() where s.UserName.Contains(search) select s).ToList();
            List<Account> listAuth = (from s in FindAll().ToList() where s.Auth.ToString().Contains(search) select s).ToList();

            if (listUName.Count != 0)
            {
                MessageBox.Show($"Tìm được {listUName.Count} kết quả");
                return listUName;
            }
            else if (listAuth.Count != 0)
            {
                MessageBox.Show($"Tìm được {listAuth.Count} kết quả");
                return listAuth;
            }
            else
            {
                MessageBox.Show($"Không có kết quả");
                return FindAll().ToList();
            }
        }
    }
}
