using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.UrlSegment.V2
{
    [ApiController]
    [ApiVersion(2.0)]
    [ApiVersion(3.0)]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UrlSegmentController : ControllerBase
    {
        [HttpGet]
        public string Get() => $"Controller = {GetType().Name}, Version = {HttpContext.GetRequestedApiVersion()}";
    }
}
