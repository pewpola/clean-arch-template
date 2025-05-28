using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchTemplate.Application.UseCases.DeleteUser
{
    public sealed record DeleteUserRequest(Guid Id) : IRequest<DeleteUserResponse>;
}
