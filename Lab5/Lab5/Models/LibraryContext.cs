using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lab5.Models
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("LibraryYeah") { }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Librarian> Librarians { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
    }
}