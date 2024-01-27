using Microsoft.AspNetCore.Mvc;

namespace KnowledgeBase.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController : ControllerBase
    {
    }
}