using AutoMapper;
using accesData = DataLayout.AccesData;
using dataModels = DataLayout.Models;

namespace BusinessLayout.Business
{
    public class ExperienceDataBL
    {
        public List<Models.ExperienceDatum>? GetExperienceData()
        {
            try
            {
                accesData.ExperienceData.ExperienceDataDL experienceDataDL = new accesData.ExperienceData.ExperienceDataDL();
                var experiencesData = experienceDataDL.GetAllExperienceData();

                if(experiencesData != null)
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<dataModels.ExperienceDatum, Models.ExperienceDatum>();
                    });

                    IMapper mapper = config.CreateMapper();
                    return mapper.Map<List<dataModels.ExperienceDatum>, List<Models.ExperienceDatum>>(experiencesData);
                }
                else
                {
                    return null;
                }
            }catch (Exception)
            {
                return null;
            }
        }
    }
}
