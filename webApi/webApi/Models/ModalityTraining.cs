﻿using System;
using System.Collections.Generic;

namespace webApi.Models;

public partial class ModalityTraining
{
    public int ModalityTrainingId { get; set; }

    public string? Modality { get; set; }

    //public virtual ICollection<EducationDatum> EducationData { get; set; } = new List<EducationDatum>();
}
