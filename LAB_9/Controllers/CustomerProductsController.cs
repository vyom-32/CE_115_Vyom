using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab11.Data;
using Lab11.Models;
using Microsoft.AspNetCore.Authorization;

namespace Lab11.Controllers
{
    [Authorize]
    public class CustomerProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CustomerProducts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CustomerProduct.Include(c => c.customer).Include(c => c.product);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CustomerProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerProduct = await _context.CustomerProduct
                .Include(c => c.customer)
                .Include(c => c.product)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customerProduct == null)
            {
                return NotFound();
            }

            return View(customerProduct);
        }

        // GET: CustomerProducts/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Id");
            ViewData["ProductId"] = new SelectList(_context.Set<Product>(), "Id", "Id");
            return View();
        }

        // POST: CustomerProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CustomerProduct customerProduct)
        {
            if (ModelState.IsValid)
            {
                CustomerProduct cp1 = customerProduct;
                Product p1 = new Product(_context);
                //customerProduct.Price = p1.getPrice(customerProduct.ProductId);
                double product = _context.Product.Where(P => P.Id == customerProduct.ProductId).Select(P => P.Price).FirstOrDefault();

                //var price = _context.products.Where(P => P.Id == customerProduct.ProductId).Include(P => P.Price).Select(P => P.Price);
                //customerProduct.Price = product;
                cp1.ProductId = customerProduct.ProductId;
                cp1.CustomerId= customerProduct.CustomerId;
                cp1.Price = product;
                cp1.Order_date= customerProduct.Order_date;

                _context.Add(cp1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Id", customerProduct.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Set<Product>(), "Id", "Id", customerProduct.ProductId);
            return View(customerProduct);
        }

        // GET: CustomerProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerProduct = await _context.CustomerProduct.FindAsync(id);
            if (customerProduct == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Id", customerProduct.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Set<Product>(), "Id", "Id", customerProduct.ProductId);
            return View(customerProduct);
        }

        // POST: CustomerProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,ProductId,Price,Order_date")] CustomerProduct customerProduct)
        {
            if (id != customerProduct.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerProductExists(customerProduct.CustomerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Id", customerProduct.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Set<Product>(), "Id", "Id", customerProduct.ProductId);
            return View(customerProduct);
        }

        // GET: CustomerProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerProduct = await _context.CustomerProduct
                .Include(c => c.customer)
                .Include(c => c.product)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customerProduct == null)
            {
                return NotFound();
            }

            return View(customerProduct);
        }

        // POST: CustomerProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customerProduct = await _context.CustomerProduct.FindAsync(id);
            _context.CustomerProduct.Remove(customerProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerProductExists(int id)
        {
            return _context.CustomerProduct.Any(e => e.CustomerId == id);
        }
    }
}
