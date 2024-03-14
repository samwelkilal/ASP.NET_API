using PaymentGateway.Domain.Entites;
using PaymentGateway.Domain.Model;
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
        Task<ResponseModel> GetByControlNumber(string controlNumber);
        Task<Payment> GetFeesById(int id);
    }
}
