using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.UrlSegment.V1
{
    [ApiController]
    [ApiVersion(1.0)]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UrlSegmentController : ControllerBase
    {
        [HttpGet]
        public string Get() => $"Controller = {GetType().Name}, Version = {HttpContext.GetRequestedApiVersion()}";
    }
}
