using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaymentGateway.Application.Command;
using PaymentGateway.Application.Query;
using PaymentGateway.Domain.Entites;
using PaymentGateway.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PaymentGateway.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalFeesController : ControllerBase
    {
       
        private readonly IMediator _mediator;

        public RentalFeesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllQuery();
            var result = await _mediator.Send(query);
            return Ok(result);

        }

        [HttpPost]
        public async Task<IActionResult> Create(AddPaymentCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetRentalFeeByIdQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }



    }
}
