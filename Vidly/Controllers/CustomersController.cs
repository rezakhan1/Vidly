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
                MemberShipType = memberShipType,
                Customer=new Customer()
            };
            return View("CustomerForm", viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save( NewCustomerViewModel cust)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewCustomerViewModel()
                {
                    Customer = cust.Customer,
                    MemberShipType=_context.MemberShipType.ToList()

                };

                return View("CustomerForm", viewModel);
            }

            if (cust.Customer.id==0)
            {
                _context.Customer.Add(cust.Customer);
            }

            else
            {
                
                //TryUpdateModel(cust.Customer, "", new string[] { "Name", "DOB" });
                var custInDb = _context.Customer.Single(c => c.id == cust.Customer.id);
              //  custInDb = cust.Customer;
             //   TryUpdateModel(custInDb);    //Not Use for Security purpose
                custInDb.Name = cust.Customer.Name;
                custInDb.DateOfBirth = cust.Customer.DateOfBirth;
                custInDb.MemberShipTypeId= cust.Customer.MemberShipTypeId;
                custInDb.isSubscribeToNewsLetter = cust.Customer.isSubscribeToNewsLetter; 
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }


        public  ActionResult Edit(int id)
        {
            var customer = _context.Customer.SingleOrDefault(c => c.id == id);

            var EditCustomer = new NewCustomerViewModel {
                Customer = customer,
                MemberShipType = _context.MemberShipType.ToList()

            };

            return View("CustomerForm", EditCustomer);

        }

    }
}