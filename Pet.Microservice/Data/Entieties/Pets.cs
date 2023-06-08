namespace Pet.Microservice.Data.Entieties
{
    public class Pets
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
        public string UserId { get; set; }

        //  public ICollection<PetUpload> PetUpload { get; set; }

        //  public string UserId { get; set; } // Foreign key for user association
        //public virtual AspNetUsers User { get; set; } // Navigation property
        public virtual AspNetUsers AspNetUsers { get; set; } = null!;
    }
}
