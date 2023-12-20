using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApi.Services.TypeConverters;
using business = BusinessLayout.Business;
using modelsBusiness = BusinessLayout.Models;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationDataController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddEducationData([FromBody] Models.EducationDatum education)
        {
            business.EducationDataBL educationDataBL = new business.EducationDataBL();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Models.EducationDatum, modelsBusiness.EducationDatum>()
                .ForMember(x => x.StartDate, y => y.ConvertUsing(new DateTimeConverter()))
                .ForMember(x => x.FinishDate, y => y.ConvertUsing(new DateTimeConverter()));
            });
            IMapper mapper = config.CreateMapper();
            var educationDatum = mapper.Map<Models.EducationDatum, modelsBusiness.EducationDatum>(education);

            var result = await educationDataBL.AddEducationData(educationDatum);

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
        public async Task<IActionResult> GetEducationDataAsync()
        {
            business.EducationDataBL educationDataBL = new business.EducationDataBL();

            var result = educationDataBL.GetEducationData();

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
