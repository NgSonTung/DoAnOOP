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
            try
            {
                db.Lops.Remove(lop);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Khong xoa duoc");
            }
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

        public List<Lop> AscLop(List<Lop> lop)
        {
            return lop.OrderBy(lp => lp.NgayKhaiGiang).ToList();
        }

        public List<Lop> TimKiemLop(string search)
        {
            List<Lop> listName = (from s in FindLop().ToList() where s.TenLop.Contains(search) select s).ToList();
            List<Lop> listId = (from s in FindLop().ToList() where s.MaLop.Contains(search) select s).ToList();

            if (listName.Count != 0)
                return listName;
            else if (listId.Count != 0)
                return listId;
            else
                return FindLop().ToList();
        }

    }
}
