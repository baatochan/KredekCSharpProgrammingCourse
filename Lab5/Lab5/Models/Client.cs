namespace Lab5.Models
{
    using System;
    using System.Collections.Generic;
    
    public class Client
    {
        public Client()
        {
            this.Reservations = new HashSet<Reservation>();
        }
    
        public int ClientID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string AddressLine1 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public Nullable<int> Phone { get; set; }
        public string Email { get; set; }
    
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
