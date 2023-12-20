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
                        cfg.CreateMap<dataModels.DetailSummary, Models.DetailSummary>();
                        cfg.CreateMap<dataModels.Skill, Models.Skill>();
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

        public async Task<Task>? AddExperienceData(Models.ExperienceDatum experienceData)
        {
            try
            {
                accesData.ExperienceData.ExperienceDataDL experienceDataDL = new accesData.ExperienceData.ExperienceDataDL();

                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Models.DetailSummary, dataModels.DetailSummary>();
                    cfg.CreateMap<Models.Skill, dataModels.Skill>();
                    cfg.CreateMap<Models.ExperienceDatum, dataModels.ExperienceDatum>();
                });
                IMapper mapper = config.CreateMapper();
                dataModels.ExperienceDatum experienceDatums = mapper.Map<Models.ExperienceDatum,dataModels.ExperienceDatum>(experienceData);
                var result = await experienceDataDL.AddExperienceData(experienceDatums);
                
                if (result != null)
                {
                    return Task.CompletedTask;
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
