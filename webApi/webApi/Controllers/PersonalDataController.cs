using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webApi.Services.TypeConverters;
using Business_ = BusinessLayout.Business;
using modelsBusiness = BusinessLayout.Models;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalDataController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddPersonalData([FromBody] Models.PersonalDatum personalData)
        {
            Business_.PersonalDataBL personalDataBL = new Business_.PersonalDataBL();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Models.Email, modelsBusiness.Email>();
                cfg.CreateMap<Models.PersonalDatum, modelsBusiness.PersonalDatum>()
                .ForMember(x => x.BornDate, y => y.ConvertUsing(new DateTimeConverter()));
            });
            IMapper mapper = config.CreateMapper();
            var personalDatum = mapper.Map<Models.PersonalDatum, modelsBusiness.PersonalDatum>(personalData);

            var result = await personalDataBL.AddPersonalData(personalDatum);

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
        public IActionResult GetPersonalDataAsync()
        {
            Business_.PersonalDataBL personalDataBL = new Business_.PersonalDataBL();

            var result = personalDataBL.GetPersonalData();

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
