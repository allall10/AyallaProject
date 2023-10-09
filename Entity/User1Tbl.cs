using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity;

public partial class User1Tbl
{
    [Key]
    public string UserId { get; set; }

    public string? Name1 { get; set; }

    public string? UserCity { get; set; }

    public string? Mail { get; set; }

    public int? Age { get; set; }

    public string? Phone { get; set; }

    public string? UserName { get; set; }

    public string? UserPassword { get; set; }

    public bool? ProfessionType { get; set; }

    public double? ExpectationsSalary { get; set; }

    public double? UserSeniority { get; set; }
}
