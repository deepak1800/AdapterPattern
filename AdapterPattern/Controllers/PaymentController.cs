using AdapterPattern.Adapter;
using AdapterPattern.CurrentInterface;
using Microsoft.AspNetCore.Mvc;

namespace AdapterPattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : Controller
    {
        private readonly ICurrentPayment _currentPayment;

        public PaymentController()
        {
            _currentPayment = new AdapterClass();
        }
        [HttpPost]
        public IActionResult Payment(string customId, decimal amount)
        {
           var result = _currentPayment.ProccessPayment(customId, amount);
            return Ok(result);
        }
    }
}
