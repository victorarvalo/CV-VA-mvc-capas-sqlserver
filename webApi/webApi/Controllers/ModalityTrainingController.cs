using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Business_ = BusinessLayout.Business;
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
            Business_.ModalityTrainingBL modalityTrainingBL = new Business_.ModalityTrainingBL();

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
        public IActionResult GetModalityTrainingAsync()
        {
            Business_.ModalityTrainingBL modalityTrainingBL = new Business_.ModalityTrainingBL();

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
