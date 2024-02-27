using Microsoft.EntityFrameworkCore;

namespace AlumnoWeb.Data
{
    public class AlumnoWebContext : DbContext
    {

        public AlumnoWebContext(DbContextOptions<AlumnoWebContext> options) : base(options)
        {
        }

        public DbSet<AlumnoWeb.Models.Alumno> Alumno { get; set; } = default!;
    }
}
