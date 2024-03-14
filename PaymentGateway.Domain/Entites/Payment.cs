using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Domain.Entites
{
    public class Payment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; }
        public DateTime CreatedAt { get; set; } // Change type to DateTime
        public string ControlNumber { get; set; }

        // Constructor to initialize CreatedAt property with current time
       
        public Payment()
        {
            CreatedAt = DateTime.Now;
            ControlNumber = GenerateUniqueToken();
        }

        // Method to generate a unique token
        private string GenerateUniqueToken()

        {
            // Generate a token combining DateTime ticks and a random number
            var ticks = DateTime.Now.Ticks;
            var random = new Random();
            var randomPart = random.Next(10000, 99999); // Adjust range according to your needs
            return $"{ticks}{randomPart}";
        }
    }

}

