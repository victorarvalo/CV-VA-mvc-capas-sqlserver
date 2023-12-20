using System;
using System.Collections.Generic;

namespace BusinessLayout.Models;

public partial class Skill
{
    public int SkillsId { get; set; }

    public string? Skill1 { get; set; }

    public int ExperienceDataId { get; set; }

    public virtual ExperienceDatum ExperienceData { get; set; } = null!;
}
