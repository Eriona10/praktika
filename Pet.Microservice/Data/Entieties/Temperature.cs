using System;
using System.Collections.Generic;

namespace Pet.Microservice.Data.Entieties;

public partial class Temperature
{
    public int Id { get; set; }

    public int Pet { get; set; }

    public double Temperature1 { get; set; }

    public DateTime? DataMeasured { get; set; }
}
