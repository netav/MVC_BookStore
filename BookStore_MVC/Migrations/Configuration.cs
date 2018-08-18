namespace BookStore_MVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookStore_MVC.Data.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookStore_MVC.Data.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Books.AddOrUpdate(_ => _.Name, new Domain.Book
            {
                Name = "C# 4.0",
                Author = "Herbert Shild",
                Price = 700,
                Rating = 4.6
            });
            context.Books.AddOrUpdate(_ => _.Name, new Domain.Book
            {
                Name = "Черновик",
                Author = "Сергей Лукьяненко",
                Price = 100,
                Rating = 5.8
            });
            context.Books.AddOrUpdate(_ => _.Name, new Domain.Book
            {
                Name = "Властелин колец",
                Author = "Рональд Роуел Толкин",
                Price = 1000,
                Rating = 5.1
            });
            context.SaveChanges();

        }
    }
}
