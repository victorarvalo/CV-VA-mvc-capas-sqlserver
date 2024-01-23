using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webApi.Services.TypeConverters;
using Business_ = BusinessLayout.Business;
using modelsBusiness = BusinessLayout.Models;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienceDataController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> AddExperienceData([FromBody] Models.ExperienceDatum experienceData)
        {
            Business_.ExperienceDataBL experienceDataBL = new Business_.ExperienceDataBL();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Models.DetailSummary, modelsBusiness.DetailSummary>();
                cfg.CreateMap<Models.Skill, modelsBusiness.Skill>();
                cfg.CreateMap<Models.ExperienceDatum, modelsBusiness.ExperienceDatum>()
                .ForMember(x => x.StartDate, y => y.ConvertUsing(new DateTimeConverter()))
                .ForMember(x => x.FinishDate, y => y.ConvertUsing(new DateTimeConverter()));
            });
            IMapper mapper = config.CreateMapper();
            var experienceDatum = mapper.Map<Models.ExperienceDatum, modelsBusiness.ExperienceDatum>(experienceData);

            var result = await experienceDataBL.AddExperienceData(experienceDatum);


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
        public IActionResult GetExperienceDataAsync()
        {
            Business_.ExperienceDataBL experienceDataBL = new Business_.ExperienceDataBL();

            var result = experienceDataBL.GetExperienceData();

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
