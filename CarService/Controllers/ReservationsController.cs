using Microsoft.AspNetCore.Mvc;

namespace CarService.Controllers
{
    [Route("api/car/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        public ReservationsController()
        {

        }

        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            System.Console.WriteLine("--> Inbound POST # Car Service");

            return Ok("Inbound test of from Reservations Controller");
        }
    }
}