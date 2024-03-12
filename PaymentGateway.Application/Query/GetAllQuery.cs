using MediatR;
using PaymentGateway.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Application.Query
{
    public class GetAllQuery:IRequest<List<Payment>> 
    {
    }
}
