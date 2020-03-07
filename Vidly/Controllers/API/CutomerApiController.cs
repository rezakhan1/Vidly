using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CutomerApiController : ApiController
    {
        private ApplicationDbContext _context;
        public CutomerApiController()
        {
            _context = new ApplicationDbContext();
        }
        //    get/api/cutomer
        public  IEnumerable<Customer> AllCustomer()
        {
         return    _context.Customer.ToList();
        }
        //  get/api/cutomet/1
        public Customer SigleCustomer(int id)
        {
            var customer= _context.Customer.SingleOrDefault(c => c.id== id);

            if (customer == null)
            {
                throw new HttpRequestException();
            }
            return customer;

        }

        //post /api/cutomer

        public Customer PostCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpRequestException(  );
            }
            _context.Customer.Add(customer);
            _context.SaveChanges();

            return customer;
        }
    }
}
