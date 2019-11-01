using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {

        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose(); 
        }

        // GET: Customer
        public ActionResult Index()
        {
            var customer = _context.Customer.Include(c => c.MemberShipType).ToList();

            return View(customer);
        }

        public ActionResult Customers()
        {
            var customer = _context.Customer.ToList() ;

            return View(customer);
            //var customer = new List<Customer>
            //{
            //    new Customer {Name="Reza" },
            //    new Customer {Name="Hanjala" }
            //};

            //var viewdatmodel = new RandomMovieViewModel()
            //{
            //    Customer = customer
            //};

            //return View(customer);
        }

        public ActionResult CustomerDetails(int Id)
        {
            var cumstomer = _context.Customer.Include(a => a.MemberShipType).SingleOrDefault(c => c.id == Id);
            if (cumstomer == null)

                return HttpNotFound();

            return View(cumstomer);


        }
        public  ActionResult New()
        {
            var memberShipType = _context.MemberShipType.ToList();
            var viewModel = new NewCustomerViewModel()
            {
                MemberShipType = memberShipType
            };
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Create( NewCustomerViewModel cust)
        {
            // return View(cust);
            _context.Customer.Add(cust.Customer);
            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }


    }
}