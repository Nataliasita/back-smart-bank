using Microsoft.AspNetCore.Mvc;
using PaymentsSmartBankAPI.Models;
using System.Collections.Generic;
using System.Linq;
using PaymentsSmartBankAPI.Data;

namespace PaymentsSmartBankAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PaymentsController(AppDbContext context)
        {
            _context = context;
        }

      
        [HttpGet("{userId}")]
        public IActionResult GetPaymentsByUser(int userId)
        {
            var userPayments = _context.Payments.Where(p => p.UserId == userId).ToList();
            if (userPayments == null || !userPayments.Any())
            {
                return NotFound("No payments found for this user.");
            }

            return Ok(userPayments);
        }

        [HttpPost]
        public IActionResult CreatePayment([FromBody] Payment payment)
        {
            
            if (payment == null)
            {
                return BadRequest("Payment data is required.");
            }

            var user = _context.Users.Find(payment.UserId);
            if (user == null)
            {
                return NotFound("User not found.");
            }

     
            payment.CreatedAt = DateTime.UtcNow;

       
            _context.Payments.Add(payment);
            _context.SaveChanges();

       
            return CreatedAtAction(nameof(GetPaymentsByUser), new { userId = payment.UserId }, payment);
        }
    }
    
}