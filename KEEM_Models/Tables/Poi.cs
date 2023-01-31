using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEEM_Models.Tables
{
    public class Poi
    {
        public int Id { get; set; }

        [Column("id_of_user")]
        public int IdOfUser { get; set; }

        public int Type { get; set; }

        [Column("owner_type")]
        public byte OwnerType { get; set; }

        [Column("Coord_Lat")]
        public double CoordLat { get; set; }

        [Column("Coord_Lng")]
        public double CoordLng { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        [MaxLength(200)]
        [Column("Name_Object")]
        public string NameObject { get; set; }
    }
}
