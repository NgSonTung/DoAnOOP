using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnOOP.PControl;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace DoAnOOP.PControl
{
    class ControlMonHoc
    {
        doAnEntities db = ControlDataBase.qlhocvien;

        public List<MonHoc> FindAllMH()
        {
            var rst = from s in db.MonHocs select s;
            return rst.ToList();
        }

        public MonHoc FindMH(string mh)
        {
            return db.MonHocs.Find(mh);
        }

        public void Add(MonHoc mh)
        {
            try
            {
                db.MonHocs.Add(mh);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Không thêm được");
            }
        }

        public void Delete(MonHoc mh)
        {
            try
            {
                db.MonHocs.Remove(mh);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Không xóa được");
            }
        }

        public void Update(MonHoc mh)
        {
            try
            {
                db.MonHocs.AddOrUpdate(mh);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Không cập nhật được");
            }
        }
    }
}
