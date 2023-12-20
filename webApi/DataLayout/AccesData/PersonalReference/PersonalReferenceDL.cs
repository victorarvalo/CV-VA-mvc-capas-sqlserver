using DataLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayout.AccesData.PersonalReference
{
    public class PersonalReferenceDL
    {
        public List<Models.PersonalReference>? GetAllPersonalReference()
        {
            try
            {
                using (SqlContext sqlContext = new SqlContext())
                {
                    return sqlContext.PersonalReferences.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Task>? AddPersonalReference(Models.PersonalReference personalReference)
        {
            try
            {
                using (SqlContext sqlContext = new SqlContext())
                {
                    await sqlContext.AddAsync(personalReference);
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
