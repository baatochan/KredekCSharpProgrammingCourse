namespace Lab5.Models
{
    using System;
    using System.Collections.Generic;
    
    public class Book
    {
        public Book()
        {
            this.Reservations = new HashSet<Reservation>();
        }
    
        public int BookID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public decimal ISBN { get; set; }
        public string Publisher { get; set; }
        public Nullable<int> YearOfPublishion { get; set; }
        public string Info { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<int> BranchID { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
