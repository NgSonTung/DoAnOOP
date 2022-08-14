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
        doAnEntities db = ControlDataBase.qlhocvien;
        public void addHsToLop(string mahv, string malop)
        {
            HocVien hv = ctrHV.FindHV(mahv);
            Lop lop = ctrClass.DefineLop(malop);
            hv.Lops.Add(lop);
            db.SaveChanges();
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
            try
            {
                HocVien hv = ctrHV.FindHV(mahv);
                Lop lop = ctrClass.DefineLop(malop);
                lop.HocViens.Add(hv);
                db.SaveChanges();
                MessageBox.Show("Xóa thành công");
            }
            catch
            {
                MessageBox.Show("Không xóa được");

            }
        }
    }
}
