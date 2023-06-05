using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pet.Microservice.Models
{

    public class PetModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public DateTime birthday { get; set; }
        public string breed { get; set; }
        public double weight { get; set; }
        public double height { get; set; }
        public string animalType { get; set; }
        public string ImagePath { get; internal set; }
        public string ImageName { get; internal set; }
        public string ImageType { get; internal set; }

        //  public ICollection<PetUpload> PetUpload { get; set; }

        //  public string UserId { get; set; } // Foreign key for user association
        //public virtual AspNetUsers User { get; set; } // Navigation property

    }
}
































/*
[Table("pet")]
public class Pet
{
    [Key]
   [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Birthday { get; set; }
    public string Gender { get; set; }
    public string Breed { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }
    public string AnimalType { get; set; }

    // [ForeignKey("device_uniqueId")]
    //      public Device Device { get; set; }
    ///    public int UserId { get; set; }
    //public User User { get; set; }

    //        [ForeignKey("ImageData_id")]
    //  public ImageData ImageData { get; set; }
    // }

    public class Device
    {
        public string DeviceUniqueId { get; set; }
        // add any other necessary properties here
    }

    public class User
    {
        public int Id { get; set; }
        public object Pets { get; set; }
        // add any other necessary properties here
    }

    public class ImageData
    {
        public int Id { get; set; }
        // add any other necessary properties here
    }
    */


