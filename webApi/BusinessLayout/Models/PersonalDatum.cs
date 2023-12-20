﻿using System;
using System.Collections.Generic;

namespace BusinessLayout.Models;

public partial class PersonalDatum
{
    public int PersonalDataId { get; set; }

    public string? PersonalName { get; set; }

    public string? Lastname { get; set; }

    public int? Age { get; set; }

    public DateTime? BornDate { get; set; }

    public DateTime? BornPlace { get; set; }

    public string? IdDocument { get; set; }

    public string? Address { get; set; }

    public string? CelPhone { get; set; }

    public string? Email { get; set; }
}
