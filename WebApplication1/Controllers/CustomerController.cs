using DataAccessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("/Customer")]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        [HttpGet]
        public string GetName()
        {
           var name = customerRepository.GetCustomersAsync().Result;
           return "seafhsdfj";
        }
    }
}
