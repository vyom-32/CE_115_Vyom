using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11.Models
{
    public class CustomerProduct
    {
       
        public int CustomerId { get; set; }
        public Customer customer { get; set; }

        public int ProductId { get; set; }
        public Product product { get; set; }

        public double? Price { get; set; }

        
        public DateTime Order_date { get; set; }
    }
}
