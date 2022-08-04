using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnOOP.PControl;
using System.Windows.Forms;

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
            return db.MonHocs.Find(mh);
        }
    }
}
