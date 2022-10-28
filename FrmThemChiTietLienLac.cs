using AppQuanLyDanhBa.Service;
using AppQuanLyDanhBa.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyDanhBa
{
    public partial class FrmThemChiTietLienLac : Form
    {
        NhomLienLacViewModel nhomlienlac;
        public FrmThemChiTietLienLac( NhomLienLacViewModel nhomlienlac = null)
        {
            InitializeComponent();
            this.nhomlienlac = nhomlienlac;
            if(nhomlienlac != null)
            {
                txtTenNhom.Text = nhomlienlac.TenNhom;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ct = new Model.ChiTietNhomLienLac
            {
                IDNhom = nhomlienlac.ID,
                TenGoi = txtTengoi.Text,
                DiaChi = txtDiaChi.Text,
                SDT = txtSDT.Text,
                Email = txtEmail.Text,

            };
            ChiTietNhomLienLacService.AddChiTietNhomLienLac(ct);
            DialogResult = DialogResult.OK;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
