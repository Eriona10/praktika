using System;
using System.Collections.Generic;

namespace Location.Microservice.Data.Entieties;

public partial class Pet
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public DateTime Birthday { get; set; }

    public string Gender { get; set; } = null!;

    public string Breed { get; set; } = null!;

    public string Weight { get; set; } = null!;

    public string Height { get; set; } = null!;

    public string AnimalType { get; set; } = null!;

    public string UserId { get; set; } = null!;
}
