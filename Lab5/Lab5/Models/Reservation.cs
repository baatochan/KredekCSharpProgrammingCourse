namespace Lab5.Models
{
    using System;
    using System.Collections.Generic;
    
    public class Reservation
    {
        public int ReservationID { get; set; }
        public int ClientID { get; set; }
        public int BookID { get; set; }
        public Nullable<System.DateTime> DateOfReservation { get; set; }
        public Nullable<System.DateTime> DateOfPickup { get; set; }
        public Nullable<System.DateTime> DateOfReturn { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Client Client { get; set; }
    }
}
