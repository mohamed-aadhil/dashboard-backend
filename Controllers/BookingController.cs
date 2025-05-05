using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dashboard_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        [HttpGet("Counts")]
        public IActionResult GetBookingsTrend([FromQuery] int year)
        {
            var path = $"Data/booking-monthly-{year}.json";
            if (!System.IO.File.Exists(path))
                return NotFound();

            var json = System.IO.File.ReadAllText(path);
            return Content(json, "application/json");
        }

        [HttpGet("Channel")]
        public IActionResult GetBookingsChannelTrend([FromQuery] int year)
        {
            var path = $"Data/booking-channel-{year}.json";
            if (!System.IO.File.Exists(path))
                return NotFound();

            var json = System.IO.File.ReadAllText(path);
            return Content(json, "application/json");
        }

    }
}
