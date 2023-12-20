using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Diagnostics;
using accesData = DataLayout.AccesData;
using dataModels = DataLayout.Models;

namespace BusinessLayout.Business
{
    public class PersonalReferenceBL
    {
        public List<Models.PersonalReference>? GetPersonalReferences()
        {
            try
            {
                accesData.PersonalReference.PersonalReferenceDL personalReferenceDL = new accesData.PersonalReference.PersonalReferenceDL();
                var personalReferences = personalReferenceDL.GetAllPersonalReference();

                if(personalReferences != null )
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<dataModels.PersonalReference, Models.PersonalReference>();
                    });
                    IMapper mapper = config.CreateMapper();
                    return mapper.Map<List<dataModels.PersonalReference>,List<Models.PersonalReference>>(personalReferences);
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
