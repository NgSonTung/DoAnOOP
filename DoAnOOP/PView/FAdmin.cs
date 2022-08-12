using DoAnOOP.PControl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
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
            dataGridView1.DataSource = hvs.ToList();

        }
        void loadFindHvByMaLop(string s)
        {
            var lst = ctrClass.findLopByMaLop(s);
            List<HocVien> hvs = new List<HocVien>();
            foreach (var l in lst)
            {
                hvs.AddRange(l.HocViens.ToList());
            }
            dataGridView1.DataSource = hvs.ToList();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            loadFindKG();
        }

        private void LapDsHvCuaMotLop_Click(object sender, EventArgs e)
        {
            if (maLopTXT.Text == "")
            {
                MessageBox.Show("Hãy nhập mã lớp");
            }
            else loadFindHvByMaLop(maLopTXT.Text.ToUpper());
        }

        private void ChoBietSLHVKGKhoaNgayNaoDo_Click(object sender, EventArgs e)
        {
            var lst = ctrClass.findLopKG(khaiGiangDP.Value);
            var rs = from t in lst
                     select new
                     {
                       TenLop  = t.TenLop,
                       NgayKhaiGiang =  t.NgayKhaiGiang,
                       SoHocVien = t.HocViens.Count
                     };

            List<HocVien> hvs = new List<HocVien>();
            foreach (var l in lst)
            {
                hvs.AddRange(l.HocViens.ToList());
            }
            test1.Text = hvs.Count.ToString();
            dataGridView1.DataSource = rs.ToList();
        }

        private void huyDangKyBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
