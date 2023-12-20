using System;
using System.Collections.Generic;

namespace webApi.Models;

public partial class Email
{
    public int EmailId { get; set; }

    public int PersonalDataId { get; set; }

    public string? Email1 { get; set; }

    //public virtual PersonalDatum PersonalData { get; set; } = null!;
}
