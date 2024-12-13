using Microsoft.AspNetCore.Mvc;
using PTPDelivery.Server.DataBase;
using PTPDelivery.Server.Models.Carrier;

namespace PTPDelivery.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarrierController : ControllerBase
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly DataContext _context;

        public CarrierController(DataContext context)
        {
            _context = context;
        }

        /// <summary>Later we could see with this funcitonnalities of crypting the password</summary>
        /// <param name="carrier">The carrier.</param>
        /// <returns>
        /// Hash the password before saving
        /// </returns>
        [HttpPost("register")]
        public async Task<IActionResult> Register(Carrier carrier)
        {
            //carrier.Password= BCrypt.Net.BCrypt.HashPassword(carrier.Password);

            _context.carriers.Add(carrier);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Carrier registered successfully" });
        }

    }
}
