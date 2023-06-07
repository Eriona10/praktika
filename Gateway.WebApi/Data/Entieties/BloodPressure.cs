using System;
using System.Collections.Generic;

namespace Gateway.WebApi.Data.Entieties;

public partial class BloodPressure
{
    public int Id { get; set; }

    public int PetId { get; set; }

    public string SystolicValue { get; set; } = null!;

    public string DiastolicValue { get; set; } = null!;

    public DateTime? DateMeasured { get; set; }
}
