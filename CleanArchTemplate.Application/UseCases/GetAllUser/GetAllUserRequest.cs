using MediatR;

namespace CleanArchTemplate.Application.UseCases.GetAllUser
{
    public sealed record GetAllUserRequest : IRequest<List<GetAllUserResponse>>;
}
