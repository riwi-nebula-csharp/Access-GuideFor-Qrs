using Microsoft.EntityFrameworkCore;
using checker.Models;
namespace ckecker.Data;

public class AppDbContext:DbContext
{
    public DbSet<Ticket> Ticket { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseMySql(
            "server=localhost;port=3307;database=nebula-ejemplo;user=root;password=root;",
            ServerVersion.AutoDetect("server=localhost;port=3307;database=nebula-ejemplo;user=root;password=root;")
        );
    }
}





  



   
