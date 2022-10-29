using AppQuanLyDanhBa.Service;
using AppQuanLyDanhBa.ViewModel;
using System;
using System.Windows.Forms;

namespace AppQuanLyDanhBa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NapDsNhomLienLac();
            NapDsChiTietNhomLienLac();
            ChiTietLienLac();
        }
        void NapDsNhomLienLac()
        {
            var ls = NhomLienLacService.getList();
            nhomLienLacViewModelBindingSource.DataSource = ls;
            dataGridViewNhomLienLac.DataSource = nhomLienLacViewModelBindingSource;
        }
        void ChiTietLienLac()
        {
            var LienLac = selectedChiTietNhomLienlac;
            if(LienLac != null)
            {
                labTenGoi.Text = $"[ {LienLac.TenGoi} ]";
                labEmail.Text = $"Email: {LienLac.Email}";
                labDiaChi.Text = $"Địa chỉ: {LienLac.DiaChi}";
                labSDT.Text = $"Số điện thoại: {LienLac.SDT}";
            }
           
        }
        /// <summary>
        /// nạp ds liên lạc vài gridview 
        /// </summary>
        void NapDsChiTietNhomLienLac()
        {
            var ls = ChiTietNhomLienLacService.getList();
            if (selectedNhomLienLac != null)
            {
                ls = ChiTietNhomLienLacService.getList(selectedNhomLienLac.ID);
            }
            chiTietNhomLienLacViewModelBindingSource.DataSource = ls;
            dataGridViewChiTiet.DataSource = chiTietNhomLienLacViewModelBindingSource;
        }

        public NhomLienLacViewModel selectedNhomLienLac
        {

            get
            {
                return nhomLienLacViewModelBindingSource.Current as NhomLienLacViewModel;
            }
        }
        //lấy sinh viên chọn trên grid
        public ChiTietNhomLienLacViewModel selectedChiTietNhomLienlac
        {

            get
            {
                return chiTietNhomLienLacViewModelBindingSource.Current as ChiTietNhomLienLacViewModel;
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        // sự kiện chọn chi tiết liên lạc
        private void dataGridViewChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ChiTietLienLac();

        }

        private void labTenGoi_Click(object sender, EventArgs e)
        {

        }
        // chọn thêm liên lạc
        private void btnThemLienLac_Click(object sender, EventArgs e)
        {
            var f = new FrmThemChiTietLienLac( selectedNhomLienLac );
            var rs = f.ShowDialog();
            //if thêm thành công thì nạp lại ds sinh viên
            if (rs == DialogResult.OK)
            {
                MessageBox.Show("Đã thêm thành công 1 nhóm liên lạc");
                NapDsChiTietNhomLienLac();
            }

        }


        // sự kiện chọn nhóm liên lạc
        private void dataGridViewNhomLienLac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapDsChiTietNhomLienLac();
        }

        //Thêm liên lạc
        private void btnThemNhom_Click(object sender, EventArgs e)
        {
            var f = new FrmThemNhomLienLac();
            f.ShowDialog();
            NapDsNhomLienLac();
            
        }

        //Xóa nhóm liên lạc
        private void btnXoaNhom_Click(object sender, EventArgs e)
        {
            //trường hợp người dùng không chọn nhóm liên lạc nào
            if(selectedNhomLienLac == null)
            {
                MessageBox.Show("Bạn chưa chọn nhóm liên lạc để xóa!");
            }
            else
            {
                var kq = NhomLienLacService.DeleteNhopLienLac(selectedNhomLienLac);
                if (kq == NhomLienLacService.KetQua.ThanhCong)
                {
                    NapDsNhomLienLac();
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công do nhóm tồn tại liên lạc!");
                }
            }
        }

        // Xóa liên lạc
        private void btnXoaLienlac_Click(object sender, EventArgs e)
        {
            if(selectedChiTietNhomLienlac == null)
            {
                MessageBox.Show("Bạn chưa chọn liên lạc để xóa");
            }
            else
            {
                ChiTietNhomLienLacService.DeleteChiTietNhomLienLac(selectedChiTietNhomLienlac);
                NapDsChiTietNhomLienLac();
                MessageBox.Show("Xóa thành công 1 liên lạc");
            }
            
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
        }
        // tìm kiếm danh bạ theo nhóm được chọn với value được nhập
        private void txtSeach_TextChanged(object sender, EventArgs e)
        {           
            var ls = ChiTietNhomLienLacService.getListByNhomBySearch(txtSeach.Text, selectedNhomLienLac.ID);
            chiTietNhomLienLacViewModelBindingSource.DataSource = ls;
            dataGridViewChiTiet.DataSource = chiTietNhomLienLacViewModelBindingSource;
        }

        
    }
}
