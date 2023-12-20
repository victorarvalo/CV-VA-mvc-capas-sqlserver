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
    }
}
