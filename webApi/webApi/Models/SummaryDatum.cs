using System;
using System.Collections.Generic;

namespace webApi.Models;

public partial class SummaryDatum
{
    public int SummaryDataId { get; set; }

    public string? Title { get; set; }

    public string? SumaryData { get; set; }
}
