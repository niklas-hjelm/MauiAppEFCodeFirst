using Microsoft.EntityFrameworkCore;

namespace MauiApp1.DataAccess;

public class MyDemoContext : DbContext
{
    public DbSet<Person> People { get; set; }

    public MyDemoContext()
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=DemoDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
}