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
                MessageBox.Show("Thêm thành công");
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
                MessageBox.Show("Xóa thành công");
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
                MessageBox.Show("Cập nhật thành công");
            }
            catch
            {
                MessageBox.Show("Không cập nhật được");
            }
        }

        public HocVien FindHV(string s)
        {
            
                return db.HocViens.Find(int.Parse(s));
            
           
        }
        public List<HocVien> findHVByMaHv(string s)
        {
            return db.HocViens.Where(t => t.MaHocVien.ToString() == s).ToList();
        }
        public List<HocVien> FindHVByName(string s)
        {
            try
            {
                return db.HocViens.Where(t =>t.HoTen == s).ToList();
            }
            catch
            {
                return null;
            }
        }
        public List<HocVien> AscHV(List<HocVien> list)
        {
            return list.OrderBy(hv => hv.NgaySinh).ToList();
        }

        public List<HocVien> SearchHV(string search)
        {
            List<HocVien> listId = (from s in FindAll().ToList() where s.MaHocVien.ToString().Contains(search) select s).ToList();
            List<HocVien> listName = (from s in FindAll().ToList() where s.HoTen.Contains(search) select s).ToList();
            List<HocVien> listBorn = (from s in FindAll().ToList() where s.NoiSinh.Contains(search) select s).ToList();
            if (listId.Count > 0)
            {
                MessageBox.Show($"Tìm được {listId.Count} kết quả");
                return listId;
            }
            else if (listName.Count > 0)
            {
                MessageBox.Show($"Tìm được {listName.Count} kết quả");
                return listName;
            }
            else if (listBorn.Count > 0)
            {
                MessageBox.Show($"Tìm được {listBorn.Count} kết quả");
                return listBorn;
            }
            else
            {
                MessageBox.Show($"Không có kết quả");
                return FindAll().ToList();
            }
        }
        
    
    }
}
