using MediatR;
using PaymentGateway.Application.Command;
using PaymentGateway.Application.Repository;
using PaymentGateway.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PaymentGateway.Application.CommandHandler
{
    public class AddPaymentCommandHandler : IRequestHandler<AddPaymentCommand, Payment>
    {
        private readonly IpaymentRepository _rep;

        public AddPaymentCommandHandler(IpaymentRepository rep)
        {
            _rep = rep;
        }

        public async Task<Payment> Handle(AddPaymentCommand request, CancellationToken cancellationToken)
        {
            var payment = new Payment
            {
                Name = request.Name,
                Amount = request.Amount.ToString() // Convert decimal to string
            };


            await _rep.AddPayment(payment);
            return payment;
        }
        }
    }

