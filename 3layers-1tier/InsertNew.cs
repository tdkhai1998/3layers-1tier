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
using BUS;

namespace _3layers_1tier
{
    public partial class InsertNew : Form
    {
        public InsertNew()
        {
            InitializeComponent();
        }
        public InsertNew(Sach s)
        {
            InitializeComponent();
            textBox_tenSach.Text = s.TenSach;
            textBox_tacGia.Text = s.TacGia;
            textBox_namXuatBan.Text = s.NamXuatBan.ToString();
            textBox_theLoai.Text = s.TheLoai;
            textBox_tomTat.Text = s.TomTat;
            textBox_soLuong.Text = s.SoLuong.ToString();

        }

     

        private void btn_themMoi_Click(object sender, EventArgs e)
        {
            Sach sach_moi = new Sach();
            sach_moi.TenSach = this.textBox_tenSach.Text;
            sach_moi.TacGia = this.textBox_tacGia.Text;
            sach_moi.TheLoai = this.textBox_theLoai.Text;
            sach_moi.TomTat = this.textBox_tomTat.Text;
            sach_moi.SoLuong = int.Parse(this.textBox_soLuong.Text);
            sach_moi.NamXuatBan = int.Parse(this.textBox_namXuatBan.Text);
            if (SachBUS.Insert(sach_moi)) {
               foreach(Control i in this.Controls)
                {
                    if(i is TextBox||i is MaskedTextBox||i is ComboBox)
                    {
                        i.Text = "";
                    }
                }
                MessageBox.Show("Đã thêm thành công");
                
            }
            else
            {
                MessageBox.Show("Thất bại");
            }

        }
    }
}
