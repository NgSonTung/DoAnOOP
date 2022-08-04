using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnOOP
{
    class ControlDataBase
    {
        public static doAnEntities qlhocvien = new doAnEntities();

        static ControlDataBase()
        {
            if (qlhocvien == null)
            {
                qlhocvien = new doAnEntities();
            }
        }
    }
}
