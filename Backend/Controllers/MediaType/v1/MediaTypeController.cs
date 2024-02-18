using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.MediaType.V1
{
    [ApiController]
    [ApiVersion(1.0)]
    [Route("api/[controller]")]
    public class MediaTypeController : ControllerBase
    {
        [HttpGet]
        public string Get() => $"Controller = {GetType().Name}, Version = {HttpContext.GetRequestedApiVersion()}";
    }
}
