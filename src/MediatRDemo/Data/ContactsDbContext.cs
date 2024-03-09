using MediatRDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace MediatRDemo.Data
{
    public class ContactsDbContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=contacts.db");
        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().ToTable("Contacts");
            modelBuilder.Entity<Contact>().HasData(
                new Contact { ContactId = 1, Name = "John Doe", Email = "johndoe@domain.com", Phone = "555-555-5555" }                
            );
        }
    }
}
