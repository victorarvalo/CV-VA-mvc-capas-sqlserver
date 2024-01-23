using DataLayout.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayout.AccesData.PersonalData
{
    public class PersonalDataDL
    {
        public List<PersonalDatum>? GetAllPersonalData()
        {
            try
            {
                using (SqlContext sqlContext = new SqlContext())
                {
                    return sqlContext.PersonalData
                        .Include( e => e.Emails)
                        .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Task>? AddPersonalData(PersonalDatum personalDatum)
        {
            try
            {
                using(SqlContext sqlContext = new SqlContext())
                {
                    await sqlContext.AddAsync(personalDatum);
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
