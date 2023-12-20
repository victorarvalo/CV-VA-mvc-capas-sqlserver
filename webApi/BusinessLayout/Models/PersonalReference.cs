using System;
using System.Collections.Generic;

namespace BusinessLayout.Models;

public partial class PersonalReference
{
    public int PersonalReferenceId { get; set; }

    public string? PersonalReferenceName { get; set; }

    public string? Celphone { get; set; }

    public string? Email { get; set; }

    public string? Occupation { get; set; }
}
