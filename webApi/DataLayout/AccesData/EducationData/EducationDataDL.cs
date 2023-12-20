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
                    return db.EducationData.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
