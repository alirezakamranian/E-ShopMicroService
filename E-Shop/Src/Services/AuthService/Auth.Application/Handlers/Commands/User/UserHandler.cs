using Auth.Application.Commands.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Application.Handlers.Commands.User
{
    public class UserHandler : IRequestHandler<UserCommand, bool>
    {
        public async Task<bool> Handle(UserCommand request, CancellationToken cancellationToken)
        {
            return true;
        }
    }
}
