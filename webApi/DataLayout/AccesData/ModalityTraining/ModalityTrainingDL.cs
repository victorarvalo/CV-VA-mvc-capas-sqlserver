using DataLayout.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayout.AccesData.ModalityTraining
{
    public class ModalityTrainingDL
    {
        public List<Models.ModalityTraining>? GetAllModalityTraining()
        {
            try
            {
                using (SqlContext sqlContext = new SqlContext())
                {
                    return sqlContext.ModalityTrainings.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Task>? AddModalityTraining(Models.ModalityTraining modalityTraining)
        {
            try
            {
                using (SqlContext sqlContext = new SqlContext())
                {
                    await sqlContext.AddAsync(modalityTraining);
                    await sqlContext.SaveChangesAsync();
                    return Task.CompletedTask;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool? ModalityTrainingExist(int modalityTrainingId)
        {
            try
            {
                using(SqlContext sqlContext = new SqlContext())
                {
                    if(sqlContext.ModalityTrainings.Any(x => x.ModalityTrainingId.Equals(modalityTrainingId)))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }catch (Exception)
            {
                return null;
            }
        }
    }
}
