using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CleanArchTemplate.Application.UseCases.CreateUser
{
    public sealed record CreateUserRequest(string Email, String Name) : IRequest<CreateUserResponse>;
    {
    }
}
