using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using business = BusinessLayout.Business;
using modelsBusiness = BusinessLayout.Models;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeTrainingController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddTypeTraining([FromBody] Models.TypeTraining typeTraining)
        {
            business.TypeTrainingBL typeTrainingBL = new business.TypeTrainingBL();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Models.TypeTraining, modelsBusiness.TypeTraining>();
            });
            IMapper mapper = config.CreateMapper();
            var typeTraining1 = mapper.Map<Models.TypeTraining, modelsBusiness.TypeTraining>(typeTraining);

            var result = await typeTrainingBL.AddTypeTraining(typeTraining1);

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
        public async Task<IActionResult> GetTypeTrainingAsync()
        {
            business.TypeTrainingBL typeTrainingBL = new business.TypeTrainingBL();

            var result = typeTrainingBL.GetTypeTraining();

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
