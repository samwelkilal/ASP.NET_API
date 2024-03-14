using MediatR;
using PaymentGateway.Application.Query;
using PaymentGateway.Application.Repository;
using PaymentGateway.Domain.Entites;
using PaymentGateway.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PaymentGateway.Application.QueryHandler
{
    public class GetPaymentByControlNumberQueryHandler:IRequestHandler<GetPaymentByControlNumberQuery,ResponseModel>  
    {
        private readonly IpaymentRepository _repository;

        public GetPaymentByControlNumberQueryHandler(IpaymentRepository repository)
        {
            _repository = repository;
        }

        public Task<ResponseModel> Handle(GetPaymentByControlNumberQuery request, CancellationToken cancellationToken)
        {
            var res = _repository.GetByControlNumber(request.ControlNumber);
            return res;
            
        }
    }
}
