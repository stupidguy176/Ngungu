using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLib;

namespace DataAccess
{
    public partial class Model
    {
        public static int DeleteHanghoa(Hanghoa cur)
        {
            //return DeleteGeneric(new { cur.HanghoaId }, cur.GetType().Name);

            var sql = "delete from Hanghoa where HanghoaId = @HanghoaId";
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter
            {
                ParameterName = "@HanghoaId",
                Value = cur.HanghoaId,
                SqlDbType = SqlDbType.Int //DbType = DbType.Int32
            });
            return db.ExecuteNonQuery(sql, param);
        }

        public static int InsertHanghoa(Hanghoa cur)
        {
            return InsertGeneric(cur);
        }

        public static List<Hanghoa> GetHanghoaItemsByNhomHanghoaId(int id)
        {
            //var sql = string.Format("select * from Hanghoa where NhomHanghoaId = {0}", id);
            //var sql = "sp_GetHanghoaItemsByNhomHanghoaId";

            var sql = "select * from Hanghoa where NhomHanghoaId = @NhomHanghoaId";
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter
            {
                ParameterName = "@NhomHanghoaId",
                Value = id,
                SqlDbType = SqlDbType.Int //DbType = DbType.Int32
            });
            return db.GetList<Hanghoa>(sql, param);
        }
        public static int AddHanghoa(Hanghoa hanghoa)
        {
            var sql = "insert into Hanghoa(HanghoaId,TenHanghoa,NhomHanghoaId) values (@HanghoaId,@TenHanghoa,@NhomHanghoaId)";
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter
            {
                ParameterName = "@HanghoaId",
                Value = hanghoa.HanghoaId,
                SqlDbType = SqlDbType.Int //DbType = DbType.Int32
            });
            param.Add(new SqlParameter
            {
                ParameterName = "@TenHanghoa",
                Value = hanghoa.TenHanghoa,
                SqlDbType = SqlDbType.NVarChar //DbType = DbType.String
            });
            param.Add(new SqlParameter
            {
                ParameterName = "@NhomHanghoaId",
                Value = hanghoa.NhomHanghoaId,
                SqlDbType = SqlDbType.Int //DbType = DbType.Int32
            });
            return db.ExecuteNonQuery(sql, param);
        }
    }
}
