using System.ComponentModel.DataAnnotations;

namespace AlumnoWeb.Models
{
    public class Alumno
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
    }
}
