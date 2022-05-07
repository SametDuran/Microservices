using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Models
{
    public class ReservationDTO
    {
        public int Id { get; set; }
        public int BKGNumber { get; set; }
        public DateTime? CheckinData { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime BkgDate { get; set; }
        public double Amount { get; set; }

    }
}
