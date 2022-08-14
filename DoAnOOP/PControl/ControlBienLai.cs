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

        public void DeleteBLtheoLop(Lop lop)
        {   
            List<BienLai> l = FindAll().Where(x => x.Lop == lop).ToList();
            foreach (var bl in l)
            {
                db.BienLais.Remove(bl);
                db.SaveChanges();
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
            List<BienLai> listId = (from s in FindAll().ToList() where s.MaBL.ToString().Contains(search) select s).ToList();
            List<BienLai> listName = (from s in FindAll().ToList() where s.MaHocVien.ToString().Contains(search) select s).ToList();
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
