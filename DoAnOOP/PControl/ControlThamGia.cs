using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnOOP.PControl
{
    public class ControlThamGia
    {
        ControlClass ctrClass = new ControlClass();
        ControlHocVien ctrHV = new ControlHocVien();
        ControlBienLai ctrBL = new ControlBienLai();
        static doAnEntities db = ControlDataBase.qlhocvien;
        public void addHsToLop(string mahv, string malop)
        {
           
            try
            {
                HocVien hv = ctrHV.FindHV(mahv);
                Lop lop = ctrClass.DefineLop(malop);
                hv.Lops.Add(lop);
                db.SaveChanges();
                MessageBox.Show("Đăng kí thành công !", "Thông báo !!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch 
            {

                MessageBox.Show("Đăng kí không thành công !", "Thông báo !!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public void RemoveHVBLTheoLop(int malop)
        {
            try
            {
                var lop = db.Lops.FirstOrDefault(x => x.MaLop == malop);
                foreach (var h in lop.HocViens.ToList())
                {
                    lop.HocViens.Remove(h);
                }
                ctrBL.DeleteBLtheoLop(lop);
                db.SaveChanges();
                MessageBox.Show("Xóa thành công");
            }
            catch
            {
                MessageBox.Show("Không xóa được");

            }
        }

        public void RemoveLopTheoHV(string mahv, string malop)
        {   
                HocVien hv = ctrHV.FindHV(mahv);
                Lop lop = ctrClass.DefineLop(malop);
            if (hv.Lops.Where(x => x.MaLop == int.Parse(malop)).ToList().Count == 0)
            {
                MessageBox.Show("Học viên không học lớp này");
            }
            else
            {
                try
                {
                    hv.Lops.Remove(lop);
                    db.SaveChanges();
                    MessageBox.Show("Hủy đăng ký thành công");
                }
                catch
                {
                    MessageBox.Show("Không hủy đăng ký được");

                }
            }
        }

        public static void RemoveLopTheoMonHV(int maHV, int maMon)
        {
            HocVien hv = db.HocViens.FirstOrDefault(x => x.MaHocVien == maHV);
            MonHoc mon = db.MonHocs.FirstOrDefault(x => x.MaMonHoc == maMon);
            if (!CheckLopTheoHV(maHV, maMon))
            {
                MessageBox.Show("Học viên không học môn này");
            }
            else
            {
                try
                {
                    Lop lop = db.Lops.FirstOrDefault(x => x.MaMonHoc == maMon);
                    hv.Lops.Remove(lop);
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Không hủy đăng ký lớp của học viên được");

                }
            }
        }

        public static bool CheckLopTheoHV(int maHV, int maMon)
        {
            var hv = db.HocViens.FirstOrDefault(x => x.MaHocVien == maHV);
            if (hv.Lops.Where(x => x.MaMonHoc == maMon).Count() == 0)
            {
                return false;
            }
            else return true;
        }
    }
}
