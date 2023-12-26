using DataAccessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Service.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("/Customer")]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository customerRepository;
        private Service.Services.ICustomerService customerService;
        public CustomerController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        //[HttpGet]
        //public List<Customer> GetCustomer()
        //{

        //}
           
        
    }
}
