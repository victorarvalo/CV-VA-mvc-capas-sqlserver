using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business_ = BusinessLayout.Business;
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
            Business_.SummaryDataBL summaryDataBL = new Business_.SummaryDataBL();

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

        [HttpGet]
        public IActionResult GetSummaryDataAsync()
        {
            Business_.SummaryDataBL summaryDataBL = new Business_.SummaryDataBL();

            var result = summaryDataBL.GetSummaryData();

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }

        }
    }
}
