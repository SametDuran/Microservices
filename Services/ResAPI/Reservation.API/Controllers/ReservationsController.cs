using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructure;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase

    {
        private readonly IReservationService _reservationService;

        public ReservationsController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id )
        {
            return Ok(_reservationService.GetReservationById(id));
        }
    }
}
