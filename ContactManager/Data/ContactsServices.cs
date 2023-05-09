using Microsoft.EntityFrameworkCore;

namespace ContactManager.Data;

// Create a contacts context class
public class ContactsContext : DbContext
{
    // Create a constructor
    public ContactsContext(DbContextOptions<ContactsContext> options) : base(options)
    {
    }

    // Create a contacts property
    public DbSet<Contacts> Contacts { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Contacts;Trusted_Connection=True;");
    }
}