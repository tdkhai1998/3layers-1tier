using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class SachBUS
    {
        public static DataTable LoadAll()
        {
            return SachDAO.SelectAll();
        }
        public static bool Insert(Sach a)
        {
            return SachDAO.Insert(a)==1?true:false;
        }
        public static bool Update(Sach a)
        {
            return SachDAO.Update(a) == 1 ? true : false;
        }
        public static bool Detete(int masach)
        {
            return SachDAO.Delete(masach) == 1 ? true : false;
        }
    }
}
