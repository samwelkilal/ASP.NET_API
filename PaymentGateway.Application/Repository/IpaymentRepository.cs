using PaymentGateway.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Application.Repository
{
    public interface IpaymentRepository
    {
        Task AddPayment(Payment payment);
        Task<List<Payment>> GetAllPaymentsAsync();
        Task<Payment> GetFeesById(int id);
    }
}
