using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using business = BusinessLayout.Business;
using modelsBusiness = BusinessLayout.Models;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalReferenceController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddPersonalReference([FromBody] Models.PersonalReference personalReference)
        {
            business.PersonalReferenceBL personalReferenceBL = new business.PersonalReferenceBL();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Models.PersonalReference, modelsBusiness.PersonalReference>();
            });
            IMapper mapper = config.CreateMapper();
            var personalReference1 = mapper.Map<Models.PersonalReference, modelsBusiness.PersonalReference>(personalReference);

            var result = await personalReferenceBL.AddPersonalReference(personalReference1);

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
        public async Task<IActionResult> GetPersonalReferenceAsync()
        {
            business.PersonalReferenceBL personalReferenceBL = new business.PersonalReferenceBL();

            var result = personalReferenceBL.GetPersonalReferences();

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
