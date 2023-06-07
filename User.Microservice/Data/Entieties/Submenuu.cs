using System;
using System.Collections.Generic;

namespace User.Microservice.Data.Entieties;

public partial class Submenuu
{
    public int SubmenuId { get; set; }

    public int MenuId { get; set; }

    public int? ParentSubId { get; set; }

    public string? NameSq { get; set; }

    public string NameEn { get; set; } = null!;

    public string NameSr { get; set; } = null!;

    public string? Claim { get; set; }

    public string? ClaimType { get; set; }

    public string? Icon { get; set; }

    public string IsActive { get; set; } = null!;

    public string? Area { get; set; }

    public string? Controller { get; set; }

    public string? Action { get; set; }

    public int OrdinalNumber { get; set; }

    public string? Roles { get; set; }

    public string? StaysOpenFor { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string IsBlazor { get; set; } = null!;
}
