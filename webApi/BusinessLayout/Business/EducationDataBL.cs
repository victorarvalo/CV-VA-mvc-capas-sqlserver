using AutoMapper;
using accesData = DataLayout.AccesData;
using dataModels = DataLayout.Models;


namespace BusinessLayout.Business
{
    public class EducationDataBL
    {
        public List<Models.EducationDatum>? GetEducationData()
        {
            try
            {
                accesData.EducationData.EducationDataDL educationDataDL = new accesData.EducationData.EducationDataDL();
                var educationsData = educationDataDL.GetAllEducationData();

                if(educationsData != null)
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<dataModels.EducationDatum, Models.EducationDatum>();
                    });

                    IMapper mapper = config.CreateMapper();
                    return mapper.Map<List<dataModels.EducationDatum>,List<Models.EducationDatum>>(educationsData);
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
