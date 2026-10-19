using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Producto> Productos { get; set; }
}

public class Producto
{
    public int Id { get; set; }
    public int NoInventario { get; set; }
    public string Descripcion { get; set; } = string.Empty;
    public string Departamento { get; set; } = string.Empty;
}