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
        }
        void NapDsNhomLienLac()
        {
            var ls = NhomLienLacService.getList();
            nhomLienLacViewModelBindingSource.DataSource = ls;
            dataGridViewNhomLienLac.DataSource = nhomLienLacViewModelBindingSource;
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

        NhomLienLacViewModel selectedNhomLienLac
        {

            get
            {
                return nhomLienLacViewModelBindingSource.Current as NhomLienLacViewModel;
            }
        }
        //lấy sinh viên chọn trên grid
        ChiTietNhomLienLacViewModel selectedChiTietNhomLienlac
        {

            get
            {
                return chiTietNhomLienLacViewModelBindingSource.Current as ChiTietNhomLienLacViewModel;
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }


       

        private void dataGridViewChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var LienLac = selectedChiTietNhomLienlac;
            labTenGoi.Text = $"[ {LienLac.TenGoi} ]";
            labEmail.Text = $"Email: {LienLac.Email}";
            labDiaChi.Text = $"Địa chỉ: {LienLac.DiaChi}";
            labSDT.Text = $"Số điện thoại: {LienLac.SDT}";
            Console.WriteLine("chán");


        }

        private void labTenGoi_Click(object sender, EventArgs e)
        {

        }

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

  


        private void dataGridViewNhomLienLac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapDsChiTietNhomLienLac();
        }

        private void btnThemNhom_Click(object sender, EventArgs e)
        {
            var f = new FrmThemNhomLienLac();
            f.ShowDialog();
            NapDsNhomLienLac();
            
        }

        private void btnXoaNhom_Click(object sender, EventArgs e)
        {
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
    }
}
