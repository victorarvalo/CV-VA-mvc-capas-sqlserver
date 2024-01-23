using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Business_ = BusinessLayout.Business;
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
            Business_.TypeTrainingBL typeTrainingBL = new Business_.TypeTrainingBL();
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
        public IActionResult GetTypeTrainingAsync()
        {
            Business_.TypeTrainingBL typeTrainingBL = new Business_.TypeTrainingBL();

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
