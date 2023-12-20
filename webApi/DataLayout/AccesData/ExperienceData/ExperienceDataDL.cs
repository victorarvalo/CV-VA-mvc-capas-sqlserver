using DataLayout.Models;
using Microsoft.EntityFrameworkCore;
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
                    var result = sqlContext.ExperienceData
                        .Include(d => d.DetailSummaries)
                        .Include(s => s.Skills)
                        .ToList();
                    return result;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Task>? AddExperienceData(ExperienceDatum experienceDatum)
        {
            try
            {
                using(SqlContext sqlContext = new SqlContext())
                {
                    await sqlContext.AddAsync(experienceDatum);
                    await sqlContext.SaveChangesAsync();
                    return Task.CompletedTask;
                }
            }catch (Exception)
            {
                return null;
            }
        }
    }
}
