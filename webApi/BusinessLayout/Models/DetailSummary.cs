﻿using AutoMapper.Configuration.Annotations;
using System;
using System.Collections.Generic;

namespace BusinessLayout.Models;

public partial class DetailSummary
{
    public int DetailSummaryId { get; set; }

    public string? Detail { get; set; }

    public int ExperienceDataId { get; set; }

    //public virtual ExperienceDatum ExperienceData { get; set; } = null!;
}
