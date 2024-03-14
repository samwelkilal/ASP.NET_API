using MediatR;
using PaymentGateway.Application.Query;
using PaymentGateway.Application.Repository;
using PaymentGateway.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PaymentGateway.Application.QueryHandler
{
    public class GetPaymentByControlNumberQueryHandler:IRequestHandler<GetPaymentByControlNumberQuery,Payment>  
    {
        private readonly IpaymentRepository _repository;

        public GetPaymentByControlNumberQueryHandler(IpaymentRepository repository)
        {
            _repository = repository;
        }

        public Task<Payment> Handle(GetPaymentByControlNumberQuery request, CancellationToken cancellationToken)
        {
            var res = _repository.GetByControlNumber(request.ControlNumber);
            return res;
            
        }
    }
}
