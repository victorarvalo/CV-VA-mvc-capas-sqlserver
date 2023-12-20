using System;
using System.Collections.Generic;

namespace BusinessLayout.Models;

public partial class DetailSummary
{
    public int DetailSummaryId { get; set; }

    public string? Detail { get; set; }

    public virtual ICollection<ExperienceDatum> ExperienceData { get; set; } = new List<ExperienceDatum>();
}
