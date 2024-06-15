using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Application.Commands.User
{
    public record UserCommand :IRequest<bool>
    {
        [Required]
        public required string Name { get; set; }
    }
}
