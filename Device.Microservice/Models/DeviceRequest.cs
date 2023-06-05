using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Device.Microservice.Models
{
    public class DeviceRequest
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [Column("uniqueId")]
        public string UniqueId { get; set; }

       
    }
}

