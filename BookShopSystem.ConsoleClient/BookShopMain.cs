using BookShopSystem.Data;
using BookShopSystem.Data.Migrations;
using BookShopSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Data.Entity.Migrations.Model.UpdateDatabaseOperation;

namespace BookShopSystem.ConsoleClient
{
    class BookShopMain
    {
        static void Main(string[] args)
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<BookShopContext, Configuration>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BookShopContext>());
            var context = new BookShopContext();
            // Initialize Database
            var bookCount = context.Books.Count();

            var book = new Book()
            {
                Title = "Kniga2",
                EditionType = 1,
                Price = 10.0m,
                Copies = 2
            };

            context.Books.Add(book);
        }
    }
}