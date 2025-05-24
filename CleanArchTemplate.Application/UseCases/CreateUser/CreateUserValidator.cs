using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace CleanArchTemplate.Application.UseCases.CreateUser
{
    public sealed class CreateUserValidator : AbstractValidator<CreateUserRequest>
    {
        public CreateUserValidator() 
        {
            RuleFor(request => request.Email).NotEmpty().MaximumLength(50).EmailAddress();
            RuleFor(request => request.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
        }
    }
}
