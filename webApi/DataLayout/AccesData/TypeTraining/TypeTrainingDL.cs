using DataLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataLayout.AccesData.TypeTraining
{
    public class TypeTrainingDL
    {
        public List<Models.TypeTraining>? GetAllTypeTraining()
        {
            try
            {
                using (SqlContext sqlContext = new SqlContext())
                {
                    return sqlContext.TypeTrainings.ToList();
                }
            }
            catch (Exception) { return null; }
        }

        public async Task<Task>? AddTypeTraining(Models.TypeTraining typeTraining)
        {
            try
            {
                using (SqlContext sqlContext = new SqlContext())
                {
                    await sqlContext.AddAsync(typeTraining);
                    await sqlContext.SaveChangesAsync();
                    return Task.CompletedTask;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool?TypeTrainingExist(int typeTrainingId)
        {
            try
            {
                using (SqlContext sqlContext = new SqlContext())
                {
                    if (sqlContext.TypeTrainings.Any(x => x.TypeTrainingId.Equals(typeTrainingId)))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }

    
}
