using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Lab11.Data;
using System.Threading.Tasks;

namespace Lab11.Models
{

    public class Product
    {
        private readonly ApplicationDbContext _context;

        public Product()
        {

        }
        public Product(ApplicationDbContext context)
        {
            _context = context;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public float Price { get; set; }

        public IList<CustomerProduct> customerProducts;


        public float getPrice(int Id)
        {
            

            var p = _context.Product.Where(P => P.Id == Id).Select(P=> new Product() { Price = P.Price });
            return this.Price;
        }
    }
}
