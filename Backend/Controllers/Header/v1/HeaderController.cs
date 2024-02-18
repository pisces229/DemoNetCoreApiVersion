using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.Header.V1
{
    [ApiController]
    [ApiVersion(1.0)]
    [Route("api/[controller]")]
    public class HeaderController : ControllerBase
    {
        [HttpGet]
        public string Get(ApiVersion apiVersion) => $"Controller = {GetType().Name}, Version = {HttpContext.GetRequestedApiVersion()}";
    }
}
