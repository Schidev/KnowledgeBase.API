using Microsoft.AspNetCore.Mvc;

namespace KnowledgeBase.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public abstract class BaseController : ControllerBase
    {
    }
}