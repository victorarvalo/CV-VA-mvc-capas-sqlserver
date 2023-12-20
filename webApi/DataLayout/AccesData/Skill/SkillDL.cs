using DataLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayout.AccesData.Skill
{
    public class SkillDL
    {
        public List<Models.Skill>? GetAllSkills()
        {
            try
            {
                using (SqlContext sqlContext = new SqlContext())
                {
                    return sqlContext.Skills.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
