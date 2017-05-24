using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DawidKobierskiLab5.Models
{
    public class Author : ModelBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
    }
}