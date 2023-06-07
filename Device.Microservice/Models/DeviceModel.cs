using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Device.Microservice.Models
{
    public class DeviceModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [Column("uniqueId")]
        public string UniqueId { get; set; }

        public string Status { get; set; }
        public bool Disabled { get; set; }
        public string LastUpdate { get; set; }
        public float PositionId { get; set; }
        public string Phone { get; set; }
        public string Model { get; set; }
        public string Contact { get; set; }
        public string Category { get; set; }

     //   public List<long> GeofenceIds { get; set; }
        // public Attributes Attributes { get; set; } // Uncomment this line if you have an "Attributes" class.

        // Add any additional properties or methods as needed.
    }
}
