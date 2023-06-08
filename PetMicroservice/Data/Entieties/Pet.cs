using System;
using System.Collections.Generic;

namespace PetMicroservice.Data.Entieties;

public partial class Pet
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public string Gender { get; set; } = null!;

    public DateTime Birthday { get; set; }

    public string Breed { get; set; } = null!;

    public double Weight { get; set; }

    public double Height { get; set; }

    public string AnimalType { get; set; } = null!;

    public string ImagePath { get; set; } = null!;

    public string ImageName { get; set; } = null!;

    public string ImageType { get; set; } = null!;

    public string UserId { get; set; } = null!;
}
