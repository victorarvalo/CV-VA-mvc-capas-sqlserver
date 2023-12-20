using DataLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayout.AccesData.SummaryData
{
    public class SummaryDataDL
    {
        public List<SummaryDatum>? GetAllSummaryData()
        {
            try
            {
                using (SqlContext sqlContext = new SqlContext())
                {
                    return sqlContext.SummaryData.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
