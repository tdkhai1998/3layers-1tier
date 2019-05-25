using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class SachDAO
    {
        public static DataTable SelectAll()
        {
            return DataProvider.Instance.ExecuteQuery("select * from sach");
        }
        public static int Insert(Sach sach)
        {
            String query = "INSERT INTO SACH VALUES( @0 , @1 , @2 , @3 , @4 , @5 , @6  )";
            return DataProvider.Instance.ExecuteNonQuery(query, sach.toArray());
        }

        public static int Update(Sach a)
        {
            String query = "INSERT INTO SACH VALUES( @0 , @1 , @2 , @3 , @4 , @5 , @6  )";
            return DataProvider.Instance.ExecuteNonQuery(query, sach.toArray());
        }
    }
}
