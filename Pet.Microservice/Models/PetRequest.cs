namespace Pet.Microservice.Models
{
    public class PetRequest
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string birthday { get; set; }
        public string breed { get; set; }
        public double weight { get; set; }
        public double height { get; set; }
        public string animalType { get; set; }
        public IFormFile ProfileImage { get; set; }
    }
}

