using ContactsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsApp.Data
{
    public class ContactsAppDbContext : DbContext
    {
        public ContactsAppDbContext(DbContextOptions<ContactsAppDbContext> options) : base(options)
        {

        }
        
        public DbSet<Contact> Contacts { get; set; }
    }
}
