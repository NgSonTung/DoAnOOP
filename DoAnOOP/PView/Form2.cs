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
        // Khoi tao controller Lop
        ControlClass ctrlLop = new ControlClass();
        Lop lop = null;
        List<Lop> dslop;

        // Khoi tao controller Mon Hoc
        ControlMonHoc ctrlMH = new ControlMonHoc();
        MonHoc mh = null;
        List<MonHoc> dsmh;

        public Form2()
        {
            InitializeComponent();
            dslop = ctrlLop.FindLop();
            lop = dslop[0];
            loadDSLop(dslop);
            LoadDataLop(lop);
            LoadDSCbMH();
        }

        #region cap thuc (binding data tu dgv vao txt)

        void LoadDataLop(Lop lop)
        {
            txtidLop.Text = lop.MaLop;
            txtTenLop.Text = lop.TenLop;
            txtHocPhi.Text = lop.HocPhi.ToString();
            dtpNKG.Value = (DateTime)lop.NgayKhaiGiang;
            /*dtpTKB.Value = s.TKB;*/
            nmrHocPhan.Value = lop.HocPhan;
            lop_monCB.SelectedItem = lop.MaMonHoc;
        }

        void LoadDataIdMH(MonHoc mh)
        {
            maMonTXT.Text = mh.MaMonHoc;
        }

        #endregion

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
            List<MonHoc> dsmh = ctrlMH.FindAllMH();
            lop_monCB.DataSource = dsmh;
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
            Lop blop = new Lop { MaLop = txtidLop.Text, TenLop = txtTenLop.Text, NgayKhaiGiang = dtpNKG.Value };
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lay gia tri vi tri
            int i = dgvLop.CurrentCell.RowIndex;
            string malop = dgvLop.Rows[i].Cells[0].Value + "";

            // Show thong tin lop dang chon
            lop = dslop.Where(t => t.MaLop == malop).ToList()[0];
            LoadDataLop(lop);
        }
    }
}
