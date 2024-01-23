using AutoMapper;
using accesData = DataLayout.AccesData;
using dataModels = DataLayout.Models;


namespace BusinessLayout.Business
{
    public class EducationDataBL
    {
        public List<Models.EducationDatum>? GetEducationData()
        {
            try
            {
                accesData.EducationData.EducationDataDL educationDataDL = new accesData.EducationData.EducationDataDL();
                var educationsData = educationDataDL.GetAllEducationData();

                if(educationsData != null)
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<dataModels.ModalityTraining, Models.ModalityTraining>();
                        cfg.CreateMap<dataModels.TypeTraining, Models.TypeTraining>();
                        cfg.CreateMap<dataModels.EducationDatum, Models.EducationDatum>();
                    });

                    IMapper mapper = config.CreateMapper();
                    return mapper.Map<List<dataModels.EducationDatum>,List<Models.EducationDatum>>(educationsData);
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

        public async Task<Task>? AddEducationData(Models.EducationDatum educationDatum)
        {
            try
            {
                accesData.EducationData.EducationDataDL educationDataDL = new accesData.EducationData.EducationDataDL();

                //validations
                accesData.ModalityTraining.ModalityTrainingDL modalityTrainingDL = new accesData.ModalityTraining.ModalityTrainingDL();
                bool? existModalityTraining = modalityTrainingDL.ModalityTrainingExist(educationDatum.ModalityTrainingId);
                if(existModalityTraining != null)
                {
                    if (!existModalityTraining.Value)
                    {
                        return null;
                    }
                }

                accesData.TypeTraining.TypeTrainingDL typeTrainingDL = new accesData.TypeTraining.TypeTrainingDL();
                bool? existTypeTraining = typeTrainingDL.TypeTrainingExist(educationDatum.TypeTrainingId);
                if(existTypeTraining != null)
                {
                    if (!existTypeTraining.Value)
                    {
                        return null;
                    }
                }

                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Models.ModalityTraining, dataModels.ModalityTraining>();
                    cfg.CreateMap<Models.TypeTraining, dataModels.TypeTraining>();
                    cfg.CreateMap<Models.EducationDatum, dataModels.EducationDatum>();
                });
                IMapper mapper = config.CreateMapper();
                dataModels.EducationDatum education = mapper.Map<Models.EducationDatum, dataModels.EducationDatum>(educationDatum);

                var result = await educationDataDL.AddEducationData(education);

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
    }
}
