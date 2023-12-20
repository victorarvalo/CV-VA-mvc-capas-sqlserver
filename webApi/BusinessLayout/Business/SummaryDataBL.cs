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

        public async Task<Task>? AddSummaryData(Models.SummaryDatum summaryDatum)
        {
            try
            {
                accesData.SummaryData.SummaryDataDL summaryDataDL = new accesData.SummaryData.SummaryDataDL();

                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Models.Email, dataModels.Email>();
                    cfg.CreateMap<Models.SummaryDatum, dataModels.SummaryDatum>();
                });
                IMapper mapper = config.CreateMapper();
                dataModels.SummaryDatum summary = mapper.Map<Models.SummaryDatum, dataModels.SummaryDatum>(summaryDatum);

                var result = await summaryDataDL.AddSummaryData(summary);

                if (result != null)
                {
                    return Task.CompletedTask;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
