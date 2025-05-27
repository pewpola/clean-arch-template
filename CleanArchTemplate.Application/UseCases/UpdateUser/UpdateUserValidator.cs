using FluentValidation;

namespace CleanArchTemplate.Application.UseCases.UpdateUser
{
    public sealed class UpdateUserValidator: AbstractValidator<UpdateUserRequest>
    {
        public UpdateUserValidator()
        {
            RuleFor(request => request.Email).NotEmpty().MaximumLength(50).EmailAddress();
            RuleFor(request => request.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
        }
    }
}
