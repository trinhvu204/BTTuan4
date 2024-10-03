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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
              
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
           NhanVien fnv = new NhanVien();
            if(fnv.ShowDialog() == DialogResult.OK) {
                dataGridView1.Rows.Add(fnv.MSNV,fnv.TenNV,fnv.LuongNV);
            }
            
        }
       
        private void btnSua_Click(object sender, EventArgs e)
        {
           
                if(dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                NhanVien fnv = new NhanVien
                {
                    MSNV = row.Cells[0].Value.ToString(),
                    TenNV = row.Cells[1].Value.ToString(),
                    LuongNV = row.Cells[2].Value.ToString(),
                };
                if (fnv.ShowDialog() == DialogResult.OK)
                {
                    row.Cells[0].Value = fnv.MSNV;
                    row.Cells[1].Value = fnv.TenNV;
                    row.Cells[2].Value = fnv.LuongNV;
                }

            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }
    }   
}
