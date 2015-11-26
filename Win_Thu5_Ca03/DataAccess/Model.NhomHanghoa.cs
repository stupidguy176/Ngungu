using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLib;

namespace DataAccess
{
    public partial class Model
    {
        public static List<NhomHanghoa> GetNhomHanghoaItems()
        {
            var item = new NhomHanghoa();
            return SelectGeneric<NhomHanghoa>(item);
        }
        public static int AddNhomHanghoa(NhomHanghoa item)
        {
            return InsertGeneric(item);
        }
        public static int UpdateNhomHanghoa(NhomHanghoa item)
        {
            return UpdateGeneric(item, "NhomHanghoaId", "NhomHanghoa");
        }
        public static int DeleteNhomHanghoa(NhomHanghoa item)
        {
            return DeleteGeneric(new { item.NhomHanghoaId }, item.GetType().Name);
        }
    }
}
