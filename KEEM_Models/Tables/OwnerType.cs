using System.Text.Json.Serialization;

namespace KEEM_Models.Tables
{    
    public class OwnerType
    {
        public byte Id { get; set; }

        public string Type { get; set; }

        [JsonIgnore]
        public ICollection<Poi> Pois { get; set; }
    }
}
