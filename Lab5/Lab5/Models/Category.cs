namespace Lab5.Models
{
    using System;
    using System.Collections.Generic;
    
    public class Category
    {
        public Category()
        {
            this.Books = new HashSet<Book>();
        }
    
        public int CategoryID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Book> Books { get; set; }
    }
}
