using AutoMapper;
using accesData = DataLayout.AccesData;
using dataModels = DataLayout.Models;

namespace BusinessLayout.Business
{
    public class PersonalDataBL
    {
        public List<Models.PersonalDatum>? GetPersonalData()
        {
            try
            {
                accesData.PersonalData.PersonalDataDL personalDataDL = new accesData.PersonalData.PersonalDataDL();
                var personalDatas = personalDataDL.GetAllPersonalData();
                if(personalDatas != null)
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<dataModels.Email, Models.Email>();
                        cfg.CreateMap<dataModels.PersonalDatum, Models.PersonalDatum>();
                    });

                    IMapper mapper = config.CreateMapper();
                    return mapper.Map<List<dataModels.PersonalDatum>, List<Models.PersonalDatum>>(personalDatas);
                }
                else
                {
                    return null;
                }
                
            }catch (Exception )
            {
                return null;
            }
        }

        public async Task<Task>? AddPersonalData(Models.PersonalDatum personalDatum)
        {
            try
            {
                accesData.PersonalData.PersonalDataDL personalDataDL = new accesData.PersonalData.PersonalDataDL();

                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Models.Email, dataModels.Email>();
                    cfg.CreateMap<Models.PersonalDatum, dataModels.PersonalDatum>();
                });
                IMapper mapper = config.CreateMapper();
                dataModels.PersonalDatum personalDatum1 = mapper.Map<Models.PersonalDatum,dataModels.PersonalDatum>(personalDatum);

                var result = await personalDataDL.AddPersonalData(personalDatum1);

                if (result != null)
                {
                    return Task.CompletedTask;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception )
            {
                return null;
            }
        }
    }
}
