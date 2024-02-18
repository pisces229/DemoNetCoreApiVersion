using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.QueryString.V1
{
    [ApiController]
    [ApiVersion(1.0)]
    [Route("api/[controller]")]
    public class QueryStringController : ControllerBase
    {
        [HttpGet]
        //public string Get(ApiVersion apiVersion) => $"Controller = {GetType().Name}, Version = {apiVersion}";
        public string Get() => $"Controller = {GetType().Name}, Version = {HttpContext.GetRequestedApiVersion()}";
    }
}
