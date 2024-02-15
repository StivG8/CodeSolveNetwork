using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace CodeSolveNetwork.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [Route("v{version:apiVersion}/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [ApiVersion("1.0")]
        public int Test(int val)
        {
            return val;
        }

        [HttpGet]
        [ApiVersion("2.0")]
        public int Test(int val, int val2)
        {
            return val * val2;
        }
    }
}
