using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity;

public partial class LanguageTbl
{
    [Key]
    public string LanguageId { get; set; }

    public string? Discription { get; set; }
}
