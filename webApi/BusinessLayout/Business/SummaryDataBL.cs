using AutoMapper;
using accesData = DataLayout.AccesData;
using dataModels = DataLayout.Models;

namespace BusinessLayout.Business
{
    public class SummaryDataBL
    {
        public List<Models.SummaryDatum>? GetSummaryData()
        {
            try
            {
                accesData.SummaryData.SummaryDataDL summaryDataDL = new accesData.SummaryData.SummaryDataDL();
                var summariesData = summaryDataDL.GetAllSummaryData();

                if(summariesData != null )
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<dataModels.SummaryDatum, Models.SummaryDatum>();
                    });

                    IMapper mapper = config.CreateMapper();
                    return mapper.Map<List<dataModels.SummaryDatum>,List<Models.SummaryDatum>>(summariesData);
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
