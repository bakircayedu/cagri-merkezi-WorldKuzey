using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev
{
    public class CagriBaslangic:CagriMerkezi
    {
        public int MusteriId { get; set; }
        public int CagriId { get; set; }
        public string MusteriTur { get; set; }
        public DateTime CagriAlisZamani { get; set; }



    }
}
