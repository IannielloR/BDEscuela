using System.ComponentModel.DataAnnotations.Schema;

namespace BDEscuela.Models
{
    public class Localidad
    {
        public int LocalidadId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set;}

    }
}
