using System.ComponentModel.DataAnnotations.Schema;

namespace BDEscuela.Models
{
    public class Profesor
    {
        public int ProfesorId { get; set; }

        public int LocalidadId { get; set; }
        [ForeignKey("LocalidadId")]
        public Localidad Localidad { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Apellido { get; set; }
    }
}
