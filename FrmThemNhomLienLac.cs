using AppQuanLyDanhBa.Service;
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
    public partial class FrmThemNhomLienLac : Form
    {
        public FrmThemNhomLienLac()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nll = new Model.NhomLienLac
            {
                TenNhom = txtTenNhomLienLac.Text,
            };
            NhomLienLacService.AddNhomLienLac(nll);
            DialogResult = DialogResult.OK;
        }

        private void txtNhomLienLac_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
