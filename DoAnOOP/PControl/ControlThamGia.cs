using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnOOP.PControl
{
    public class ControlThamGia
    {
        ControlClass ctrClass = new ControlClass();
        ControlHocVien ctrHV = new ControlHocVien();
        doAnEntities db = ControlDataBase.qlhocvien;
        public void addHsToLop(string mahv, string malop)
        {
            HocVien hv = ctrHV.FindHV(mahv);
            Lop lop = ctrClass.DefineLop(malop);
            hv.Lops.Add(lop);
            db.SaveChanges();
        }
       
    }
}
