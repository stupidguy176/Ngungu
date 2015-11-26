using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidu01
{
    public class Lop
    {
        public int LopId { get; set; }
        public string TenLop { get; set; }
        public string GVCN { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}",TenLop,GVCN);
        }

        public string LopDisplay
        {
            get
            {
                return ToString();
            }
        }
    }
}
