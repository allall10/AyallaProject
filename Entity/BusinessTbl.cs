using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity;

public partial class BusinessTbl
{
    [Key]
    public string BusinessId { get; set; }

    public string? BusinessName { get; set; }

    public string? BusinessCity { get; set; }

    public bool? ProfessionType { get; set; }

    public string? LanguageId { get; set; }

    public double? NumWeekHours { get; set; }

    public int? SeniorityBusiness { get; set; }

    public double? SalaryHour { get; set; }
}
