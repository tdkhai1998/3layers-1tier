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
        private int mode = 0;
        private Sach sach_chinh_sua = null;
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
            label_tenForm.Text = "CHỈNH SỬA SÁCH";
            btn_themMoi.Text = "CẬP NHẬT";
            sach_chinh_sua = s;
            mode = 1;
        }

     
        private void ThemMoi()
        {
            Sach sach_moi = new Sach();
            sach_moi.TenSach = this.textBox_tenSach.Text;
            sach_moi.TacGia = this.textBox_tacGia.Text;
            sach_moi.TheLoai = this.textBox_theLoai.Text;
            sach_moi.TomTat = this.textBox_tomTat.Text;
            sach_moi.SoLuong = int.Parse(this.textBox_soLuong.Text);
            sach_moi.NamXuatBan = int.Parse(this.textBox_namXuatBan.Text);
            switch (sach_moi.isValid())
            {
                case 0:
                    if (SachBUS.Insert(sach_moi))
                    {
                        foreach (Control i in this.Controls)
                        {
                            if (i is TextBox || i is MaskedTextBox || i is ComboBox)
                            {
                                i.Text = "";
                            }
                        }
                        if (MessageBox.Show("Đã thêm thành công") == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                        this.DialogResult = DialogResult.No;
                    }
                    break;
                case 1:
                    MessageBox.Show("VUI LÒNG NHẬP TÊN SÁCH");
                    break;
                case 2:
                    MessageBox.Show("VUI LÒNG NHẬP TÊN TÁC GIẢ");
                    break;
                case 3:
                    MessageBox.Show("SỐ LƯỢNG PHẢI LỚN HƠN 0");
                    break;
                case 4:
                    MessageBox.Show("VUI LÒNG NHẬP THỂ LOẠI");
                    break;
                case 5:
                    MessageBox.Show("VUI LÒNG NHẬP TÓM TẮT");
                    break;
            }
            
        }

        private void ChinhSua()
        {
            sach_chinh_sua.TenSach = this.textBox_tenSach.Text;
            sach_chinh_sua.TacGia = this.textBox_tacGia.Text;
            sach_chinh_sua.TheLoai = this.textBox_theLoai.Text;
            sach_chinh_sua.TomTat = this.textBox_tomTat.Text;
            sach_chinh_sua.SoLuong = int.Parse(this.textBox_soLuong.Text);
            sach_chinh_sua.NamXuatBan = int.Parse(this.textBox_namXuatBan.Text);
            switch (sach_chinh_sua.isValid())
            {
                case 0:
                    if (SachBUS.Update(sach_chinh_sua))
                    {
                        if (MessageBox.Show("Cập nhật thành công") == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại rồi");
                        this.DialogResult = DialogResult.No;
                    }
                    break;
                case 1:
                    MessageBox.Show("VUI LÒNG NHẬP TÊN SÁCH");
                    break;
                case 2:
                    MessageBox.Show("VUI LÒNG NHẬP TÊN TÁC GIẢ");
                    break;
                case 3:
                    MessageBox.Show("SỐ LƯỢNG PHẢI LỚN HƠN 0");
                    break;
                case 4:
                    MessageBox.Show("VUI LÒNG NHẬP THỂ LOẠI");
                    break;
                case 5:
                    MessageBox.Show("VUI LÒNG NHẬP TÓM TẮT");
                    break;
            }
        }
        private void btn_themMoi_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                ThemMoi();
            }
            else
            {
                ChinhSua();
            }

        }

        private void textBox_soLuong_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_soLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
