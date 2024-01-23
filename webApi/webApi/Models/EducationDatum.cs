using System;
using System.Collections.Generic;

namespace webApi.Models;

public partial class EducationDatum
{
    public int EducationDataId { get; set; }

    public int TypeTrainingId { get; set; }

    public int ModalityTrainingId { get; set; }

    public string? Title { get; set; }

    public string? Institution { get; set; }

    public string? StartDate { get; set; }

    public string? FinishDate { get; set; }

    public string? Summary { get; set; }

    //public virtual ModalityTraining ModalityTraining { get; set; } = null!;

    //public virtual TypeTraining TypeTraining { get; set; } = null!;
}
