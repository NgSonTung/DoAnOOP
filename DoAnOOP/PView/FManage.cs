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
    public partial class FManage : Form
    {
        HocVienCTR ctrHV = new HocVienCTR();
        ControlClass ctrlLop = new ControlClass();
        Lop lop = null;
        List<Lop> dslop;

        public FManage()
        {
            InitializeComponent();
            loadDSHV();
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
        void loadDSHV()
        {
            var list = from s in ctrHV.FindAll() select new {s.MaHocVien , s.HoTen, s.NgaySinh, s.NoiSinh, s.NgheNghiep };
            if (ctrHV.FindAll().Count != 0)
                loadHV(ctrHV.FindAll()[0]);
            dgvHV.DataSource = list.ToList();
        }

        void loadDSHV(List<HocVien> l)
        {
            var list = from s in l select new { s.MaHocVien, s.HoTen, s.NgaySinh, s.NoiSinh, s.NgheNghiep };
            if (ctrHV.FindAll().Count != 0)
                loadHV(ctrHV.FindAll()[0]);
            dgvHV.DataSource = list.ToList();
        }

        void loadHV(HocVien hv)
        {
            mahvTXT.Text = hv.MaHocVien;
            hotenhvTXT.Text = hv.HoTen;
            ngaysinhhvDP.Value = hv.NgaySinh;
            noisinhhvTXT.Text = hv.NoiSinh;
            nghenghiephvTXT.Text = hv.NgheNghiep;
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

        private void themhvBTN_Click(object sender, EventArgs e)
        {
            HocVien check = ctrHV.FindHV(mahvTXT.Text);
            if (check == null)
            {
                HocVien hv = new HocVien { MaHocVien = mahvTXT.Text, HoTen = hotenhvTXT.Text, NgaySinh = ngaysinhhvDP.Value, NoiSinh = noisinhhvTXT.Text, NgheNghiep = nghenghiephvTXT.Text };
                ctrHV.Add(hv);
                loadDSHV();
            }
            else
            {
                MessageBox.Show("Trùng mã khoa");
            }
        }

        private void dgvHV_SelectionChanged(object sender, EventArgs e)
        {
            int index = dgvHV.CurrentCell.RowIndex;
            string id = dgvHV.Rows[index].Cells[0].Value + "";
            if (ctrHV.FindHV(id) != null)
            loadHV(ctrHV.FindHV(id));
        }

        private void xoahvBTN_Click(object sender, EventArgs e)
        {
            int index = dgvHV.CurrentCell.RowIndex;
            string id = dgvHV.Rows[index].Cells[0].Value + "";
            ctrHV.Delete(ctrHV.FindHV(id));
            loadDSHV();
        }

        private void lietkehvBTN_Click(object sender, EventArgs e)
        {
            loadDSHV(ctrHV.AscHV(ctrHV.FindAll()));

        }

        private void xemhvBTN_Click(object sender, EventArgs e)
        {
            loadDSHV();
        }

        private void capnhathvBTN_Click(object sender, EventArgs e)
        {
            int index = dgvHV.CurrentCell.RowIndex;
            string id = dgvHV.Rows[index].Cells[0].Value + "";
            HocVien hv = ctrHV.FindHV(id);
            hv.HoTen = hotenhvTXT.Text;
            hv.NgaySinh = ngaysinhhvDP.Value;
            hv.NoiSinh = noisinhhvTXT.Text;
            hv.NgheNghiep = nghenghiephvTXT.Text;
            ctrHV.Update(hv);
            loadDSHV();
        }

        private void timKiemHVBTN_Click(object sender, EventArgs e)
        {
            loadDSHV(ctrHV.SearchHV(timKiemHVTXT.Text));
        }

        private void themhvBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Thêm học viên vào danh sách";
        }

        private void xoahvBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Xóa học viên khỏi danh sách";
        }

        private void capnhathvBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Cập nhật thông tin học viên";
        }

        private void lietkehvBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Sắp xếp học viên theo ngày sinh tăng dần";
        }

        private void timKiemHVBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Tìm kiếm học viên theo mã, tên hoặc nơi sinh";
        }

        private void xemhvBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Xuất danh sách học viên gốc";
        }

        private void themhvBTN_MouseLeave(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void xoahvBTN_MouseLeave(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void capnhathvBTN_MouseLeave(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void lietkehvBTN_MouseLeave(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void timKiemHVBTN_MouseLeave(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void xemhvBTN_MouseLeave(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FAdmin f = new FAdmin();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
