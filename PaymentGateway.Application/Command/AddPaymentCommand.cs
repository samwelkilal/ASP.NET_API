using MediatR;
using PaymentGateway.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Application.Command
{
    public class AddPaymentCommand:IRequest<Payment>
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}
