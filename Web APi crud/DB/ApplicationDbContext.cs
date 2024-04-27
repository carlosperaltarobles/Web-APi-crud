using Microsoft.EntityFrameworkCore;
using Web_APi_crud.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Estudiante> Estudiantes { get; set; }
}