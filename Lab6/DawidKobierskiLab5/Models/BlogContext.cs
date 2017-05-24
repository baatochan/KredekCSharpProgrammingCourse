using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DawidKobierskiLab5.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("KredekBlog")
        {}

        public IDbSet<Post> Posts { get; set; }
        public IDbSet<Comment> Comments { get; set; }
    }
}