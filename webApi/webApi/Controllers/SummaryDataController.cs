using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using business = BusinessLayout.Business;
using modelsBusiness = BusinessLayout.Models;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SummaryDataController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddSummaryData([FromBody] Models.SummaryDatum summary)
        {
            business.SummaryDataBL summaryDataBL = new business.SummaryDataBL();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Models.SummaryDatum, modelsBusiness.SummaryDatum>();
            });
            IMapper mapper = config.CreateMapper();
            var summaryDatum = mapper.Map<Models.SummaryDatum, modelsBusiness.SummaryDatum>(summary);

            var result = await summaryDataBL.AddSummaryData(summaryDatum);

            if (result != null)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
