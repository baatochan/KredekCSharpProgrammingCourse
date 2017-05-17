namespace Lab5.Models
{
    using System;
    using System.Collections.Generic;
    
    public class Librarian
    {
        public int LibrarianID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Nullable<System.DateTime> HireDate { get; set; }
    }
}
