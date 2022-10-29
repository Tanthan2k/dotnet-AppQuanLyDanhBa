using AppQuanLyDanhBa.Service;
using AppQuanLyDanhBa.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyDanhBa
{
    public partial class FrmThemChiTietLienLac : Form
    {
        ErrorProvider err;
        NhomLienLacViewModel nhomlienlac;
        public FrmThemChiTietLienLac( NhomLienLacViewModel nhomlienlac = null)
        {
            InitializeComponent();
            this.nhomlienlac = nhomlienlac;
            err = new ErrorProvider();
            if(nhomlienlac != null)
            {
                txtTenNhom.Text = nhomlienlac.TenNhom;
            }
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        /// <summary>
        /// Thêm 1 số điện thoại vào nhóm danh bạ if số điên thoại trùng thì không thêm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            //kiểm tra số điện thoại có để trống không
            if (String.IsNullOrEmpty(txtSDT.Text))
            {
                err.SetError(txtSDT, "Số điện thoại không được để trống!");
                return;
            }
            else
            {
                // kiểm tra xem chuỗi nhập vào có phải là số không
                if (!IsNumber(txtSDT.Text))
                {
                    err.SetError(txtSDT, "Số điện thoại không hợp lệ [0-9]!");
                    return;
                }
            }
           
            //kiểm tra tên gọi có để trống không
            if (String.IsNullOrEmpty(txtTengoi.Text))
            {
                err.SetError(txtTengoi, "Tên gọi không được để trống!");
                return;
            }
            //tạo liên lạc
            var ct = new Model.ChiTietNhomLienLac
            {
                IDNhom = nhomlienlac.ID,
                TenGoi = txtTengoi.Text,
                DiaChi = txtDiaChi.Text,
                SDT = txtSDT.Text,
                Email = txtEmail.Text,

            };
            var Result = ChiTietNhomLienLacService.AddChiTietNhomLienLac(ct);
            //kiểm xem số điện thoại có tồn tại trong danh bạ không
            if(Result == ChiTietNhomLienLacService.KetQua.TrungMa)
            {
                MessageBox.Show("Số điện thoại đã tồn tại trong danh bạ!");
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
            
        }
    }
}
