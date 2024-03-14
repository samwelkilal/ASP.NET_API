using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PaymentGateway.Application.Repository;
using PaymentGateway.Domain.Entites;
using PaymentGateway.Domain.Model;
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
        private readonly IMapper _mapper;

        public paymentRepository(PaymentDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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

        public async Task<ResponseModel> GetByControlNumber(string controlNumber)
        {
            var res = await _context.payments.FirstOrDefaultAsync(P => P.ControlNumber == controlNumber);
            return _mapper.Map<ResponseModel>(res); 
        }

        public async Task<Payment> GetFeesById(int id)
        {
            var res =await _context.payments.FindAsync(id);
            return res;
        }
    }
    }
