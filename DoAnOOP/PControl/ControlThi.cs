using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnOOP.PControl
{
    internal class ControlThi
    {
        doAnEntities db = ControlDataBase.qlhocvien;

        public List<Thi> FindAll()
        {
            var rst = from s in db.This select s;
            return rst.ToList();
        }

        public Thi FindDiem(string id)
        {
            return db.This.Find(int.Parse(id));
        }

        public void Add(Thi mh)
        {
            try
            {
                db.This.Add(mh);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Không thêm được");
            }
        }
    }
}
