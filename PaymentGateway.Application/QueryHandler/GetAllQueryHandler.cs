using MediatR;
using PaymentGateway.Application.Query;
using PaymentGateway.Application.Repository;
using PaymentGateway.Domain.Entites;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PaymentGateway.Application.QueryHandler
{
    public class GetAllQueryHandler : IRequestHandler<GetAllQuery, List<Payment>>
    {
        private readonly IpaymentRepository _repo;

        public GetAllQueryHandler(IpaymentRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Payment>> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
           
            var payments = await _repo.GetAllPaymentsAsync();

           
            return payments;
        }
    }
}
