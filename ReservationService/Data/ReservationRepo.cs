using System;
using System.Collections.Generic;
using System.Linq;
using ReservationService.Models;

namespace ReservationService.Data
{
    public class ReservationRepo : IReservationRepo
    {
        private readonly AppDbContext context;

        public ReservationRepo(AppDbContext context)
        {
            this.context = context;
        }
        public void CreateReservation(Reservation reservation)
        {
            if(reservation == null)
            {
                throw new ArgumentNullException(nameof(reservation));
            }
            else
            {
                this.context.Reservations.Add(reservation);
            }
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            return this.context.Reservations.ToList();
        }

        public Reservation GetReservationById(int Id)
        {
            return this.context.Reservations.FirstOrDefault(r => r.Id == Id);
        }

        public bool SaveChanges()
        {
            return (this.context.SaveChanges() >= 0);
        }
    }
}