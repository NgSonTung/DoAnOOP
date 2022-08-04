using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnOOP.PControl;

namespace DoAnOOP.PControl
{
    class ControlClass
    {
        doAnEntities db = ControlDataBase.qlhocvien;

        public void add(Lop lop)
        {
            try
            {
                db.Lops.Add(lop);
                db.SaveChanges();
            }
            catch
            {
                return;
            }
        }

        public List<Lop> FindLop()
        {
            var rst = from s in db.Lops select s;
            return rst.ToList();
        }

        public void delete(Lop lop)
        {
            db.Lops.Remove(lop);
            db.SaveChanges();
        }

        public void update(Lop lop)
        {
            db.Lops.AddOrUpdate(lop);
            db.SaveChanges();
        }

        public Lop DefineLop(string s)
        {
            return db.Lops.Find(s);
        }
    }
}
