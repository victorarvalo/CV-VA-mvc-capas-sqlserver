using DataLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayout.AccesData.DetailSummary
{
    public class DetailSummaryDL
    {
        public List<Models.DetailSummary>? GetAllDetailSummaries()
        {
            try
            {
                using (SqlContext sqlContext = new SqlContext())
                {
                    return sqlContext.DetailSummaries.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
