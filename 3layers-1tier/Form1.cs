using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace _3layers_1tier
{
    public partial class SÁCH : Form
    {
       
        public SÁCH()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dGrV_main.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridView_EditingControlShowing);
        }
        private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress +=
                new KeyPressEventHandler(Control_KeyPress);
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dGrV_main.CurrentCell.ValueType == typeof(Int32))
            {
                if (char.IsNumber(e.KeyChar)||char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void btn_load_all_Click(object sender, EventArgs e)
        {
            dGrV_main.DataSource = SachBUS.LoadAll();
            dGrV_main.Columns[0].ReadOnly = true;
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            InsertNew fm = new InsertNew();
            if (fm.ShowDialog() == DialogResult.OK)
            {
                dGrV_main.DataSource = SachBUS.LoadAll();
            };
        }
        private void Edit(Sach s)
        {
            InsertNew fm = new InsertNew(s);
            fm.ShowDialog();
        }
        private Sach createSach(DataGridViewCellCollection r)
        {
            Sach s = new Sach();
            try
            {
                s.MaSach = int.Parse(r["masach"].Value.ToString());
                s.TenSach = r["tensach"].Value.ToString();
                s.TacGia = r["tacgia"].Value.ToString();
                s.NamXuatBan = int.Parse(r["namxuatban"].Value.ToString());
                s.SoLuong = int.Parse(r["soluong"].Value.ToString());
                s.TomTat = r["tomtat"].Value.ToString();
                s.TheLoai = r["theloai"].Value.ToString();
            }
            catch
            {
                return null;
            }
            return s;
        }
        private void dGrV_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Update_Click(null, null);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow i in dGrV_main.SelectedRows)
            {
                SachBUS.Detete(int.Parse(i.Cells["masach"].Value.ToString()));
            }
            btn_load_all_Click(null, null);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int index = dGrV_main.SelectedRows.Count;
            if (index > 0)
            {
                DataGridViewCellCollection r = dGrV_main.SelectedRows[0].Cells;
                Sach s = createSach(r);
                InsertNew fm = new InsertNew(s);
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    dGrV_main.DataSource = SachBUS.LoadAll();
                };
            }
        }

        private void btn_UpdateAll_Click(object sender, EventArgs e)
        {
            int success = 0;
           foreach(DataGridViewRow r in dGrV_main.Rows)
            {
                Sach s = createSach(r.Cells);
                if (s!=null&&SachBUS.Update(s))
                {
                    success++;
                }
            }
            MessageBox.Show("CẬP NHẬT THÀNH CÔNG " + success.ToString() + " dòng!");
        }

        private void dGrV_main_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dGrV_main_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dGrV_main_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
