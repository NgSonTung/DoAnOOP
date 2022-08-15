using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnOOP.PControl
{
    internal class ControlAccount
    {
        public static doAnEntities db = ControlDataBase.qlhocvien;

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
    }
}
