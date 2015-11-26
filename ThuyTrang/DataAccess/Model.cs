using DatabaseLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DataAccess
{
    public class Model
    {
        static SqlDatabase db = new SqlDatabase();

        public static List<Trang_Master> GetTrang_MasterItems()
        {
            return db.GetList<Trang_Master>("Select * from Trang_Master");
        }
       public static List<Trang_Detail> GetTrang_DetailItemsByNhomHangID(int id)
        {
            //var sql = string.Format("select * from Hanghoa where NhomHangID = {0}", id);
            //var sql = "sp_GetHanghoaItemsByNhomHangID";

            var sql = "select * from Trang_Detail where NhomHangID = @NhomHangID";
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter
            {
                ParameterName = "@NhomHangID",
                Value = id,
                SqlDbType = SqlDbType.Int //DbType = DbType.Int32
            });
            return db.GetList<Trang_Detail>(sql, param);
        }
       
      public static int Insert(Trang_Detail hanghoa)
        {
            var sql = "insert into Trang_Detail(HangHoa,Gia,NhomHangID) values (@HangHoa,@Gia,@NhomHangID)";
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter
            {
                ParameterName = "@HangHoa",
                Value = hanghoa.HangHoa,
                SqlDbType = SqlDbType.Int //DbType = DbType.Int32
            });
            param.Add(new SqlParameter
            {
                ParameterName = "@Gia",
                Value = hanghoa.Gia,
                SqlDbType = SqlDbType.NVarChar //DbType = DbType.String
            });
         /*   param.Add(new SqlParameter
            {
                ParameterName = "@DonVi",
                Value = hanghoa.DonVi,
                SqlDbType = SqlDbType.NVarChar //DbType = DbType.String
            });*/
            param.Add(new SqlParameter
            {
                ParameterName = "@NhomHangID",
                Value = hanghoa.NhomHangID,
                SqlDbType = SqlDbType.Int //DbType = DbType.Int32
            });
            return db.ExecuteNonQuery(sql, param);
        }
        
        public static int InsertGeneric(object item)
        {
            return db.ExecuteNonQuery(item.ToSqlInsert(), item.ToSqlParameter());
        }
    }
}
