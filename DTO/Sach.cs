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
        public Sach(String ts, String tg, String tl, int nxb, int sl, String tt = "")
        {
            TenSach = ts;
            TacGia = tg;
            TheLoai = tl;
            NamXuatBan = nxb;
            SoLuong = sl;
            TomTat = tt;
        }
    
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
        public object[] toArray()
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
        public object[] toArrayNotID()
        {
            return new object[]
            {
               TenSach,
               NamXuatBan,
               TacGia,
               TomTat,
               TheLoai,
               SoLuong
            };
        }
        public int isValid()
        {
            if (TenSach.Equals("")) return 1;
            if (TacGia.Equals("")) return 2;
            if (SoLuong <= 0) return 3;
            if (TheLoai.Equals("")) return 4;
            if (TomTat.Equals("")) return 5;
            return 0;
        }
    }
}
