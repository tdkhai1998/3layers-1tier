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
        public static int Insert(Sach a)
        {
            return SachDAO.Insert(a);
        }
    }
}
