using System;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace BookInventory
{
    class BookContext : DbContext
    {
        public DbSet<Book> MyLibrary { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);
            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;
            String DatabaseFile = Path.Combine(ProjectBase.FullName, "library.db");
            optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
        }
    }
}