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
    }
}
