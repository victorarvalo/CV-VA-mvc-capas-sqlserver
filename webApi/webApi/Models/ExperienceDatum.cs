using System;
using System.Collections.Generic;

namespace webApi.Models;

public partial class ExperienceDatum
{
    public int ExperienceDataId { get; set; }

    public string? Enterprise { get; set; }

    public string? Phone { get; set; }

    public string? Url { get; set; }

    public string? Position { get; set; }

    public string? Summary { get; set; }

    public string? StartDate { get; set; }

    public string? FinishDate { get; set; }

    public int DetailSumaryId { get; set; }

    public int SkillsId { get; set; }

    public virtual ICollection<DetailSummary>? DetailSummaries { get; set; } = new List<DetailSummary>();

    public virtual ICollection<Skill>? Skills { get; set; } = new List<Skill>();
}
