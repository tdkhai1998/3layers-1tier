using System;
using System.Data;
using DTO;
namespace DAO
{
    public class SachDAO
    {
        static String[] columnName = { "tensach", "namxuatban", "tacgia","tomtat", "theloai", "soluong"};
        public static DataTable SelectAll()
        {
            return DataProvider.Instance.ExecuteQuery("select * from sach");
        }
        public static int Insert(Sach sach)

        {
            String query = "INSERT INTO SACH VALUES( @0 , @1 , @2 , @3 , @4 , @5 , @6  )";
            return DataProvider.Instance.ExecuteNonQuery(query, sach.toArray());
        }

        public static int Delete(int masach)
        {
            return DataProvider.Instance.ExecuteNonQuery("DELETE FROM SACH WHERE MASACH = " + masach);
        }

        public static int Update(Sach a)
        {
            String query = "UPDATE SACH SET ";
            foreach(String col in columnName)
            {
           
                query += " "+col + " = @" + col + " ,";
            }
            query=query.Remove(query.LastIndexOf(','));
            query += "WHERE masach = "+a.MaSach.ToString()+";";
        
            return DataProvider.Instance.ExecuteNonQuery(query, a.toArrayNotID());
        }
    }
}
