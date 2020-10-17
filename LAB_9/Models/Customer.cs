using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public double Mno { get; set; }

        public IList<CustomerProduct> customerProducts;
    }
}
