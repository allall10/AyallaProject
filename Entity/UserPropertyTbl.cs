using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity;

public partial class UserPropertyTbl
{
    [Key]
    public string UserPropertiesId { get; set; }

    public string? UserId { get; set; }

    public string? LanguageId { get; set; }

    public int? SeniorityLanguage { get; set; }

    public double? NumMonthLearn { get; set; }

    public string? Diploma { get; set; }
}
