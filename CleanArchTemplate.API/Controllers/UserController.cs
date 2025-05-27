using CleanArchTemplate.Application.UseCases.CreateUser;
using CleanArchTemplate.Application.UseCases.GetAllUser;
using CleanArchTemplate.Application.UseCases.UpdateUser;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchTemplate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpPost]
        public async Task<ActionResult<CreateUserResponse>> Create(CreateUserRequest request, CancellationToken cancellationToken)
        {
            var validator = new CreateUserValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var response = await _mediator.Send(request, cancellationToken);

            return Ok(response);
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllUserResponse>>> GetAll(CancellationToken cancellation)
        {
            var request = new GetAllUserRequest();
            var response = await _mediator.Send(request, cancellation);

            if (response == null || !response.Any())
            {
                return NotFound("No users found.");
            }

            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateUserResponse>> Update(Guid id, UpdateUserRequest request, CancellationToken cancellationToken)
        {
            if (id != request.Id)
            {
                return BadRequest();
            }

            var response = await _mediator.Send(request, cancellationToken);

            return Ok(response);
        }
    }
}
