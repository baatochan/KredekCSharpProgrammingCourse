namespace DawidKobierskiLab5.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DawidKobierskiLab5.Models.BlogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DawidKobierskiLab5.Models.BlogContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Posts.AddOrUpdate(
                p => p.Title, 
                new Post
                {
                    Title = "Hello kredek! 4",
                    Body = "CPC-2017-1-Kredek",
                    Author = new Author
                    {
                        FirstName = "Dawid",
                        LastName = "Kobierski",
                        Username = "dkobierski"
                    }
                },
                new Post
                {
                    Title = "Hello kredek! 5",
                    Body = "CPC-2017-1-Kredek",
                    Author = new Author
                    {
                        FirstName = "Artur",
                        LastName = "Jordan",
                        Username = "ajordan"
                    }
                },
                new Post
                {
                    Title = "Hello kredek! 6",
                    Body = "CPC-2017-1-Kredek",
                    Author = new Author
                    {
                        FirstName = "Karolina",
                        LastName = "Herlender",
                        Username = "kherlender"
                    }
                }
                );
        }
    }
}
