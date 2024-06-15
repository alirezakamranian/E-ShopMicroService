using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Api.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public class IControllerBase : ControllerBase
    {
    }
}
