using DataLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayout.AccesData.ExperienceData
{
    public class ExperienceDataDL
    {
        public List<ExperienceDatum>? GetAllExperienceData()
        {
            try
            {
                using (SqlContext sqlContext = new SqlContext())
                {
                    return sqlContext.ExperienceData.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
