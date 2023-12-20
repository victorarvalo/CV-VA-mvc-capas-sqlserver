using AutoMapper;
using accesData = DataLayout.AccesData;
using dataModels = DataLayout.Models;

namespace BusinessLayout.Business
{
    public class ModalityTrainingBL
    {
        public List<Models.ModalityTraining>? GetModalityTraining()
        {
            try
            {
                accesData.ModalityTraining.ModalityTrainingDL modalityTrainingBL = new accesData.ModalityTraining.ModalityTrainingDL();
                var modalityTraining = modalityTrainingBL.GetAllModalityTraining();

                if (modalityTraining != null)
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<dataModels.ModalityTraining, Models.ModalityTraining>();
                    });

                    IMapper mapper = config.CreateMapper();
                    return mapper.Map<List<dataModels.ModalityTraining>, List<Models.ModalityTraining>>(modalityTraining);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Task>? AddModalityTraining(Models.ModalityTraining modalityTraining)
        {
            try
            {
                accesData.ModalityTraining.ModalityTrainingDL modalityTrainingDL = new accesData.ModalityTraining.ModalityTrainingDL();

                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Models.ModalityTraining, dataModels.ModalityTraining>();
                });
                IMapper mapper = config.CreateMapper();
                dataModels.ModalityTraining modality = mapper.Map<Models.ModalityTraining, dataModels.ModalityTraining>(modalityTraining);

                var result = await modalityTrainingDL.AddModalityTraining(modality);

                if (result != null)
                {
                    return Task.CompletedTask;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool? ModalityTrainingExist(int modalityTrainingId)
        {
            try
            {
                accesData.ModalityTraining.ModalityTrainingDL modalityTrainingDL = new accesData.ModalityTraining.ModalityTrainingDL();
                bool? exist = modalityTrainingDL.ModalityTrainingExist(modalityTrainingId);
                if(exist != null)
                {
                    return exist;
                }
                else
                {
                    return null;
                }
            }catch (Exception)
            {
                return null;
            }
        }
    }
}
