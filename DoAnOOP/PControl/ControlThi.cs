using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnOOP.PControl
{
    internal class ControlThi
    {
        private static doAnEntities db = ControlDataBase.qlhocvien;

        public static List<Thi> FindAll()
        {
            var rst = from s in db.This select s;
            return rst.ToList();
        }

        public static Thi FindThi(int maHV, int maMon)
        {
            List<Thi> lThi = db.This.Where(x => x.MaHocVien == maHV).ToList();
            return lThi.FirstOrDefault(x => x.MaMonHoc == maMon);
        }

        public static void Add(Thi thi)
        {
            try
            {
                db.This.Add(thi);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Không thêm được");
            }
        }

        public void RemoveThiTheoHV(int mahv, int maMon)
        {
            Thi thi = db.This.FirstOrDefault(t => t.MaMonHoc == maMon && t.MaHocVien == mahv);
            try
            {
                db.This.Remove(thi);
                db.SaveChanges();
                MessageBox.Show("Xóa thành công");
            }
            catch
            {
                MessageBox.Show("Không xóa được");
            }
        }

        public static void Update(Thi thi)
        {
            try
            {
                db.This.AddOrUpdate(thi);
                db.SaveChanges();
                MessageBox.Show("Cập nhật thành công");
            }
            catch
            {
                MessageBox.Show("Không cập nhật được");
            }
        }

        public static List<Thi> Search(string search)
        {
            List<Thi> listId = (from s in FindAll().ToList() where s.HocVien.HoTen.ToString().Contains(search) select s).ToList();
            List<Thi> listName = (from s in FindAll().ToList() where s.MonHoc.TenMonHoc.Contains(search) select s).ToList();
            if (listName.Count != 0)
            {
                MessageBox.Show($"Tìm được {listName.Count} kết quả");
                return listName;
            }
            else if (listId.Count != 0)
            {
                MessageBox.Show($"Tìm được {listId.Count} kết quả");
                return listId;
            }
            else
            {
                MessageBox.Show($"Không có kết quả");
                return FindAll().ToList();
            }
        }
    }
}
