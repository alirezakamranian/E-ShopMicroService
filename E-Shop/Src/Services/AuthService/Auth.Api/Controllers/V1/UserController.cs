using Auth.Api.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Auth.Application.Commands.User;

namespace Auth.Api.Controllers.V1
{
    [Route("api/v1/user")]
    [ApiController]
    public class UserController(IMediator mediator) : IControllerBase
    {
        public readonly IMediator _mediator = mediator;

        /// <summary>
        /// Add User Credentials
        /// </summary>
        /// <returns></returns>
        [HttpPost("Insert")]
        public async Task<IActionResult> Insert([FromBody]UserCommand userCommand)
        {
            var response = await _mediator.Send(userCommand);
            return Ok();
        }
    }
}
