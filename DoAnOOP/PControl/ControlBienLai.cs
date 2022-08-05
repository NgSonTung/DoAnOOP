using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnOOP.PControl
{
    internal class ControlBienLai
    {
        doAnEntities db = ControlDataBase.qlhocvien;

        public List<BienLai> FindAll()
        {
            var blList = from s in db.BienLais select s;
            return blList.ToList();
        }

        public void Add(BienLai bl)
        {
            try
            {
                db.BienLais.Add(bl);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Không thêm được");
            }
        }

        public void Delete(BienLai bl)
        {
            try
            {
                db.BienLais.Remove(bl);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Không xóa được");
            }
        }

        public void Update(BienLai bl)
        {
            try
            {
                db.BienLais.AddOrUpdate(bl);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Không cập nhật được");
            }
        }

        public List<BienLai> FindBL(DateTime date1, DateTime date2)
        {
            return (from s in FindAll().ToList() where s.NgayDong > date1 && s.NgayDong < date2 select s).ToList();
        }

        public List<BienLai> DescBL(List<BienLai> list)
        {
            return list.OrderByDescending(hv => hv.NgayDong).ToList();
        }

        public List<BienLai> SearchBL(string search)
        {
            List<BienLai> listId = (from s in FindAll().ToList() where s.MaBL.Contains(search) select s).ToList();
            List<BienLai> listName = (from s in FindAll().ToList() where s.MaHocVien.Contains(search) select s).ToList();
            if (listId.Count > 0)
                return listId;
            else if (listName.Count > 0)
                return listName;
            else return FindAll().ToList();
        }
    }
}
