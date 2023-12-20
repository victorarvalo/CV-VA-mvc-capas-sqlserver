using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using business = BusinessLayout.Business;
using modelsBusiness = BusinessLayout.Models;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModalityTrainingController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddModalityTraining([FromBody] Models.ModalityTraining modalityTraining)
        {
            business.ModalityTrainingBL modalityTrainingBL = new business.ModalityTrainingBL();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Models.ModalityTraining, modelsBusiness.ModalityTraining>();
            });
            IMapper mapper = config.CreateMapper();
            var modality = mapper.Map<Models.ModalityTraining, modelsBusiness.ModalityTraining>(modalityTraining);

            var result = await modalityTrainingBL.AddModalityTraining(modality);

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
        public async Task<IActionResult> GetModalityTrainingAsync()
        {
            business.ModalityTrainingBL modalityTrainingBL = new business.ModalityTrainingBL();

            var result = modalityTrainingBL.GetModalityTraining();

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
