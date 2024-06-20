using Auth.Api.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Auth.Application.Commands.User;
using Asp.Versioning;

namespace Auth.Api.Controllers.V1
{
    [ApiController]
    [ApiVersion(1)]
    [Route("api/v{v:apiVersion}/user")]
    public class UserController() : IControllerBase
    {
        [HttpGet]
        [MapToApiVersion(1)]
        public async Task<IActionResult> get()
        {
            return Ok("ffdsd");
        }
    }
}
