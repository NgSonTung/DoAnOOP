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
    public partial class Form2 : Form
    {
        ControlClass ctrlLop = new ControlClass();
        Lop lop = null;
        List<Lop> dslop;

        public Form2()
        {
            InitializeComponent();
            dslop = ctrlLop.FindLop();
            lop = dslop[0];
            loadDSLop(dslop);
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        void loadDSLop(List<Lop> lst)
        {
            var rs = from s in lst
                     select new
                     {
                         s.MaLop,
                         s.TenLop,
                         s.TKB,
                         s.NgayKhaiGiang,
                         s.HocPhan,
                         s.HocPhi,
                         s.MaMonHoc
                     };

            dgvLop.DataSource = rs.ToList();
        }

        void LoadDSCbMH()
        {
            List<MonHoc> dsmonhoc = new List<MonHoc>();
            lop_monCB.DataSource = dsmonhoc;
        }

        private void capnhatlopBTN_Click(object sender, EventArgs e)
        {
            // Xac dinh vi tri can update
            int index = dgvLop.CurrentCell.RowIndex;
            string lop = dgvLop.Rows[index].Cells[0].Value + "";

            Lop s = ctrlLop.DefineLop(lop); // Tim kiem lop can thay doi
            s.MaLop = txtidLop.Text;
            s.TenLop = txtTenLop.Text;
            s.NgayKhaiGiang = dtpNKG.Value.Date;
            /*s.TKB = dtpTKB.Value.Date;*/
            s.HocPhan = int.Parse(nmrHocPhan.Value+"");
            s.HocPhi = float.Parse(txtHocPhi.Text);
            s.MaMonHoc = lop_monCB.Text;

            ctrlLop.update(s);
            loadDSLop(dslop);


        }

        private void themlopBTN_Click(object sender, EventArgs e)
        {

        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lay gia tri vi tri
            int i = dgvLop.CurrentCell.RowIndex;
            string showLop = dgvLop.Rows[i].Cells[0] + "";

            // Show thong tin lop dang chon
            Lop s = ctrlLop.DefineLop(showLop);
            if (s != null)
            {
                txtidLop.Text = s.MaLop;
                txtTenLop.Text = s.TenLop;
                txtHocPhi.Text = s.HocPhi.ToString();
                dtpNKG.Value = (DateTime)s.NgayKhaiGiang;
                /*dtpTKB.Value = s.TKB;*/
                nmrHocPhan.Value = s.HocPhan;
                lop_monCB.SelectedItem = s.MaMonHoc;
            }
        }
    }
}
