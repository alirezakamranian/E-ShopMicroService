using Auth.Domain.Entities;
using Auth.Domain.Repository.Command.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Domain.Repository.Command
{
    public interface IUserCommandRepository : ICommandRepository<User>
    {

    }
}
