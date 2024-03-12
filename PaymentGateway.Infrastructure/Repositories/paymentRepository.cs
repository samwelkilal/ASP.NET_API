using Microsoft.EntityFrameworkCore;
using PaymentGateway.Application.Repository;
using PaymentGateway.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Infrastructure.Repositories
{
    public class paymentRepository : IpaymentRepository
    {
        private readonly PaymentDbContext _context;

        public paymentRepository(PaymentDbContext context)
        {
            _context = context;

        }

        public async Task AddPayment(Payment payment)
        {
            await _context.AddAsync(payment);
            await _context.SaveChangesAsync();
            
        }

        public async Task<List<Payment>> GetAllPaymentsAsync()
        {
           var res = await _context.payments.ToListAsync();
            return res;
        }

       

        public async Task<Payment> GetFeesById(int id)
        {
            var res =await _context.payments.FindAsync(id);
            return res;
        }
    }
    }
