using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
