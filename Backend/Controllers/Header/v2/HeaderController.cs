using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.Header.V2
{
    [ApiController]
    //[ApiVersion(2.0)]
    [ApiVersion(2.0, Deprecated = true)]
    [ApiVersion(3.0)]
    [Route("api/[controller]")]
    public class HeaderController : ControllerBase
    {
        [HttpGet]
        public string Get() => $"Controller = {GetType().Name}, Version = {HttpContext.GetRequestedApiVersion()}";
        //[HttpGet, MapToApiVersion("3")]
        //public string GetV3() => $"Controller = {GetType().Name}, Version = {HttpContext.GetRequestedApiVersion()}";
    }
}
