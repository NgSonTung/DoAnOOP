using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnOOP.PControl;
using System.Data.Entity.Migrations;
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
                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Không thêm được");
            }
        }

        public List<Lop> FindLop()
        {
            var rst = from s in db.Lops select s;
            return rst.ToList();
        }

        public void delete(Lop lop)
        {   
            if (lop.HocViens.Count > 0 || lop.BienLais.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Lớp đang có học viên, tiếp tục xóa sẽ hủy lớp của học viên và biên lai có liên quan", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ControlThamGia ctrThamGia = new ControlThamGia();
                    db.Lops.Remove(lop);
                    db.SaveChanges();
                }
            }
            else
            {
                try
                {
                    db.Lops.Remove(lop);
                    
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công");
                }
                catch
                {
                    MessageBox.Show("Không xóa được");
                }
            }
        }

        public void update(Lop lop)
        {
            try
            {
                db.Lops.AddOrUpdate(lop);
                db.SaveChanges();
                MessageBox.Show("Cập nhật thành công");
            }
            catch
            {
                MessageBox.Show("Không cập nhật được");
            }
        }

        public Lop DefineLop(string s)
        {
            return db.Lops.Find(int.Parse(s));
        }

        public List<Lop> AscLop(List<Lop> lop)
        {
            return lop.OrderByDescending(lp => lp.NgayKhaiGiang).ToList();
        }

        public List<Lop> TimKiemLop(string search)
        {
            List<Lop> listName = (from s in FindLop().ToList() where s.TenLop.Contains(search) select s).ToList();
            List<Lop> listId = (from s in FindLop().ToList() where s.MaLop.ToString().Contains(search) select s).ToList();
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
                return FindLop().ToList();
            }
        }
        public List<Lop> findLopKG(DateTime dt)
        {
            return db.Lops.Where(t => t.NgayKhaiGiang == dt.Date).ToList();
        }
        public List<Lop> findLopByMaLop(string s)
        {
            return db.Lops.Where(t => t.MaLop.ToString() == s).ToList();
        }
        public Lop findInfoLop(int malop)
        {
            return db.Lops.Find(malop); 
        }
        public List<Lop> findLopByName(string s)
        {
            try
            {
                return db.Lops.Where(t => t.TenLop.ToString() == s).ToList();

            }
            catch 
            {

                return null;
            }
        }
    }
}
