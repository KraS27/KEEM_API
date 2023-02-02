using KEEM_Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEEM_Models.ViewModels
{
    public class PoiVM
    {
        public int Id { get; set; }

        public int IdOfUser { get; set; }

        public int Type { get; set; }
        
        public string OwnerType { get; set; }

        public double CoordLat { get; set; }

        public double CoordLng { get; set; }

        public string Description { get; set; }

        public string NameObject { get; set; }
    }
}
