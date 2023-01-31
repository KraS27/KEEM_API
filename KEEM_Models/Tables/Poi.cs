using System;

namespace KEEM_Models.Tables
{   
    public class Poi
    {
        public int Id { get; set; }

        public int IdOfUser { get; set; }

        public int Type { get; set; }
        
        public byte OwnerTypeId { get; set; }
        public OwnerType OwnerType { get; set; }
        
        public double CoordLat { get; set; }
       
        public double CoordLng { get; set; }
        
        public string Description { get; set; }
       
        public string NameObject { get; set; }
    }
}
