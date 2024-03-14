using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Domain.Model
{
    public class ResponseModel

    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } 
        public string ControlNumber { get; set; }

    }
}
