using System;
using System.Collections.Generic;

namespace BusinessLayout.Models;

public partial class TypeTraining
{
    public int TypeTrainingId { get; set; }

    public string? TrainingType { get; set; }

    public virtual ICollection<EducationDatum> EducationData { get; set; } = new List<EducationDatum>();
}
