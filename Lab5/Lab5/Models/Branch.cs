namespace Lab5.Models
{
    using System;
    using System.Collections.Generic;
    
    public class Branch
    {
        public Branch()
        {
            this.Books = new HashSet<Book>();
        }
    
        public int BranchID { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public Nullable<int> Phone { get; set; }
    
        public virtual ICollection<Book> Books { get; set; }
    }
}
