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
    }
}
