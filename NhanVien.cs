using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTuan4
{
    public partial class NhanVien : Form

    {
        public string MSNV {  get; set; }
        public string TenNV {  get; set; }  
        public string LuongNV {  get; set; }    

        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            txtMSNV.Text = MSNV;
            txtMSNV.Text = TenNV;
            txtLuongCB.Text = LuongNV;

           

        }
         
        private void btnDongY_Click(object sender, EventArgs e)
        {
            MSNV = txtMSNV.Text;
            TenNV = txtTenNV.Text;
            LuongNV = txtLuongCB.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
