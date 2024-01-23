using System;
using System.Collections.Generic;

namespace DataLayout.Models;

public partial class Email
{
    public int PersonalDataId { get; set; }

    public string? Email1 { get; set; }

    public int EmailId { get; set; }

    public virtual PersonalDatum PersonalData { get; set; } = null!;
}
