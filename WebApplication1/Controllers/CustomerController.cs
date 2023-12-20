using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("/Customer")]
    public class CustomerController : Controller
    {
        public string GetName()
        {
            return "Duy Man";
        }
    }
}
