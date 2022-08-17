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

        private void Add(HocVien hv, double hocPhi)
        {   
            BienLai bl = new BienLai {NgayDong = DateTime.Now, SoTien = hocPhi, MaHocVien = hv.MaHocVien };
            try
            {
                db.BienLais.Add(bl);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Không thêm được");
            }
        }
        public void AddBLDK(HocVien hv, double hocPhi, int malop)
        {
            BienLai bl = new BienLai { NgayDong = DateTime.Now, SoTien = hocPhi, MaHocVien = hv.MaHocVien,MaLop = malop };
            try
            {
                db.BienLais.Add(bl);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Không thể tạo biên lai cho học phần này !! Hãy thử lại","Thông báo !",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void DeleteBLtheoLop(Lop lop)
        {   
            List<BienLai> l = FindAll().Where(x => x.Lop == lop).ToList();
            foreach (var bl in l)
            {
                db.BienLais.Remove(bl);
                db.SaveChanges();
            }
        }

        public double TongDoanhThu()
        {
            double result = 0;
            List<BienLai> l = FindAll().ToList();
            foreach (var bl in l)
            {
                result += bl.SoTien;
            }
            return result;
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
            List<BienLai> listId = (from s in FindAll().ToList() where s.MaBL.ToString().Contains(search) select s).ToList();
            List<BienLai> listName = (from s in FindAll().ToList() where s.HocVien.HoTen.ToString().Contains(search) select s).ToList();
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
            else
            {
                MessageBox.Show($"Không có kết quả");
                return FindAll().ToList();
            }
        }
    }
}
