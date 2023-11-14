using KnowledgeBase.WebAPI.Models.Base;
using KnowledgeBase.WebAPI.Models.Dictionary.Languages;
using Microsoft.AspNetCore.Mvc;

namespace KnowledgeBase.WebAPI.Controllers.DictionaryControllers
{
    public class LanguagesController : BaseController
    {
        [HttpGet]
        public ActionResult<ResponseDTO> GetAll()
        {    
            List<CreateLanguageModel> languages = new List<CreateLanguageModel>
            {
                new CreateLanguageModel { Id = new Guid("193cc7bf-332e-41ba-ac9b-67dea2819908"), Content = "UNDETECTED", Code = "ucd" },
                new CreateLanguageModel { Id = new Guid("98773fab-2ebd-46c7-b69d-89af4ce77aca"), Content = "Русский", Code = "rus" }
            };

            ResponseDTO response = new ResponseDTO()
            {
                IsSuccess = true,
                Result = languages,
                Message = ""
            };

            return Ok(response);
        }

        [HttpGet("{id}")]
        public ActionResult<ResponseDTO> GetLanguageDetails(Guid id)
        {
            List<CreateLanguageModel> languages = new List<CreateLanguageModel>
            {
                new CreateLanguageModel { Id = new Guid("193cc7bf-332e-41ba-ac9b-67dea2819908"), Content = "UNDETECTED", Code = "ucd" },
                new CreateLanguageModel { Id = new Guid("98773fab-2ebd-46c7-b69d-89af4ce77aca"), Content = "Русский", Code = "rus" }
            };

            ResponseDTO response = new ResponseDTO()
            {
                IsSuccess = true,
                Result = languages.Where(language => language.Id.Equals(id)),
                Message = ""
            };

            return Ok(response);
        }
    }
}