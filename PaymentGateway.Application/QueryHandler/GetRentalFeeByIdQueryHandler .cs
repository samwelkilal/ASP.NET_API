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
    public class GetRentalFeeByIdQueryHandler : IRequestHandler<GetRentalFeeByIdQuery, Payment>
    {
        private readonly IpaymentRepository _repo;

        public GetRentalFeeByIdQueryHandler(IpaymentRepository repo)
        {
            _repo = repo;
        }

        public async Task<Payment> Handle(GetRentalFeeByIdQuery request, CancellationToken cancellationToken)
        {
            var rentalFee = await _repo.GetFeesById(request.Id);
            return rentalFee;
        }
    }
}