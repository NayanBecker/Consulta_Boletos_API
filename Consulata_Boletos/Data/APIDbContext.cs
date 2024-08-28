using Consulata_Boletos.Models;
using Microsoft.EntityFrameworkCore;

namespace Consulata_Boletos.Data;

public class APIDbContext : DbContext
{
    public APIDbContext(DbContextOptions <APIDbContext> options) : base(options)
        { }

    public DbSet<Banco> banco { get; set; }
    public DbSet<Boleto> Boleto { get; set; }
}
