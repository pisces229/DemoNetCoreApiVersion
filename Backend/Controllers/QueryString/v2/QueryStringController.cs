using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.QueryString.V2
{
    [ApiController]
    [ApiVersion(2.0)]
    [ApiVersion(3.0)]
    [Route("api/[controller]")]
    public class QueryStringController : ControllerBase
    {
        [HttpGet]
        public string Get() => $"Controller = {GetType().Name}, Version = {HttpContext.GetRequestedApiVersion()}";
    }
}
