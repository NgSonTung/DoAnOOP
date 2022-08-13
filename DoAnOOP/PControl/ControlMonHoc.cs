using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnOOP.PControl;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using DoAnOOP.PView;

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
            return db.MonHocs.Find(int.Parse(mh));
        }

        public void Add(MonHoc mh)
        {
            try
            {
                db.MonHocs.Add(mh);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công");
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
                MessageBox.Show("Xóa thành công");
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
                MessageBox.Show("Cập nhật thành công");
            }
            catch
            {
                MessageBox.Show("Không cập nhật được");
            }
        }

        public List<MonHoc> SubjectSearching(string search)
        {
            List<MonHoc> listId = (from s in FindAllMH().ToList() where s.MaMonHoc.ToString().Contains(search) select s).ToList();
            List<MonHoc> listName = (from s in FindAllMH().ToList() where s.TenMonHoc.Contains(search) select s).ToList();
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
                return FindAllMH().ToList();
            }
        }
    }
}
