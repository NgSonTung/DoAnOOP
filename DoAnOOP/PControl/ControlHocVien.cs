using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnOOP.PControl
{
    internal class ControlHocVien
    {
        doAnEntities db = ControlDataBase.qlhocvien;

        public List<HocVien> FindAll()
        {
            var hvList = from s in db.HocViens select s;
            return hvList.ToList();
        }

        public void Add(HocVien hv)
        {
            try
            {
                db.HocViens.Add(hv);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Không thêm được");
            }
        }

        public void Delete(HocVien hv)
        {
            try
            {
                db.HocViens.Remove(hv);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Không xóa được");
            }
        }

        public void Update(HocVien hv)
        {
            try
            {
                db.HocViens.AddOrUpdate(hv);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Không cập nhật được");
            }
        }

        public HocVien FindHV(string s)
        {
            return db.HocViens.Find(s);
        }

        public List<HocVien> AscHV(List<HocVien> list)
        {
            return list.OrderBy(hv => hv.NgaySinh).ToList();
        }

        public List<HocVien> SearchHV(string search)
        {
            List<HocVien> listId = (from s in FindAll().ToList() where s.MaHocVien.Contains(search) select s).ToList();
            List<HocVien> listName = (from s in FindAll().ToList() where s.HoTen.Contains(search) select s).ToList();
            List<HocVien> listBorn = (from s in FindAll().ToList() where s.NoiSinh.Contains(search) select s).ToList();
            if (listId.Count > 0)
                return listId;
            else if (listName.Count > 0)
                return listName;
            else if (listBorn.Count > 0)
                return listBorn;
            else return FindAll().ToList();
        }
    }
}
