using DataLayout.Models;
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
                    return sqlContext.PersonalData.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
