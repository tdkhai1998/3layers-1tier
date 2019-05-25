using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach
    {
        public int MaSach{ get; set; }
        public String TenSach { get; set; }
        public int NamXuatBan { get; set; }
        public String TacGia { get; set; }
        public String TomTat { get; set; }
        public String TheLoai { get; set; }
        public int SoLuong { get; set; }
        public Sach()
        {
            MaSach = -1;
            TenSach = "";
            NamXuatBan = -1;
            TacGia = "";
            TomTat = "";
            TheLoai = "";
            SoLuong = -1;
        }
        public object[] toArray(obmấch)
        {
            return new object[]
            {
               null,
               TenSach,
               NamXuatBan,
               TacGia,
               TomTat,
               TheLoai,
               SoLuong
            };
        }
    }
}
