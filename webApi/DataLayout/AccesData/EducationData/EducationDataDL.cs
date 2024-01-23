using DataLayout.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayout.AccesData.EducationData
{
    public class EducationDataDL
    {
        public List<EducationDatum>? GetAllEducationData()
        {
            try
            {
                using (SqlContext db = new SqlContext())
                {
                    return db.EducationData
                        .Include(m => m.ModalityTraining)
                        .Include(t => t.TypeTraining)
                        .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Task>? AddEducationData(EducationDatum educationDatum)
        {
            try
            {
                using (SqlContext sqlContext = new SqlContext())
                {
                    await sqlContext.AddAsync(educationDatum);
                    await sqlContext.SaveChangesAsync();
                    return Task.CompletedTask;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
