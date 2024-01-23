using AutoMapper;
using accesData = DataLayout.AccesData;
using dataModels = DataLayout.Models;

namespace BusinessLayout.Business
{
    public class TypeTrainingBL
    {
        public List<Models.TypeTraining>? GetTypeTraining()
        {
            try
            {
                accesData.TypeTraining.TypeTrainingDL typeTrainingDL = new accesData.TypeTraining.TypeTrainingDL();
                var typeTraining = typeTrainingDL.GetAllTypeTraining();

                if (typeTraining != null)
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<dataModels.TypeTraining, Models.TypeTraining>();
                    });

                    IMapper mapper = config.CreateMapper();
                    return mapper.Map<List<dataModels.TypeTraining>, List<Models.TypeTraining>>(typeTraining);
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

        public async Task<Task>? AddTypeTraining(Models.TypeTraining typeTraining)
        {
            try
            {
                accesData.TypeTraining.TypeTrainingDL typeTrainingDL = new accesData.TypeTraining.TypeTrainingDL();

                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Models.TypeTraining, dataModels.TypeTraining>();
                });
                IMapper mapper = config.CreateMapper();
                dataModels.TypeTraining typeTraining1 = mapper.Map<Models.TypeTraining, dataModels.TypeTraining>(typeTraining);

                var result = await typeTrainingDL.AddTypeTraining(typeTraining1);

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

        public bool? TypeTrainingExist(int typeTrainingId)
        {
            try
            {
                accesData.TypeTraining.TypeTrainingDL typeTrainingDL = new accesData.TypeTraining.TypeTrainingDL();
                bool? exist = typeTrainingDL.TypeTrainingExist(typeTrainingId);
                if (exist != null)
                {
                    return exist;
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
    }
}
