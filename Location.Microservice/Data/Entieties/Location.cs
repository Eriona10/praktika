using System;
using System.Collections.Generic;

namespace Location.Microservice.Data.Entieties;

public partial class Location
{
    public int Id { get; set; }

    public int PetId { get; set; }

    public double Lat { get; set; }

    public double Long { get; set; }

    public DateTime? DataMeaured { get; set; }
}
