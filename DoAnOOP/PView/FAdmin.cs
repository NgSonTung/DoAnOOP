using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnOOP.PControl;
namespace DoAnOOP
{
    public partial class FAdmin : Form
    {
        ControlClass ctrClass = new ControlClass();
        ControlHocVien ctrHV = new ControlHocVien();
        Lop lp = null;
        public FAdmin()
        {
            InitializeComponent();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FManage f = new FManage();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void FAdmin_Load(object sender, EventArgs e)
        {

        }

        void loadFindKG()
        {



            var lst = ctrClass.findLopKG(khaiGiangDP.Value);
            List<HocVien> hvs = new List<HocVien>();
            foreach (var l in lst)
            {
                hvs.AddRange(l.HocViens.ToList());
                //addrange add can list 
            }

            //var rs = from t in lst select new { t.HocViens};
            
            //foreach (List<HocVien> i in rs.ToList())
            //{
            //    foreach (var j in i)
            //    {

            //    }
            //}
            dataGridView1.DataSource = hvs.ToList();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadFindKG();
        }
    }
}
