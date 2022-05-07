using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetReservationById(int id)
        {
            return new ReservationDTO { Id = id, BKGNumber=new Random().Next(100), Amount=new Random().NextDouble() ,BkgDate=DateTime.Now.Date,CheckinData=DateTime.Now.Date.AddDays(30), CheckoutDate=DateTime.Today.AddDays(45)};
        }
    }
}
