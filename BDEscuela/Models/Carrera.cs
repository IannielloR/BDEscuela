using System.ComponentModel.DataAnnotations.Schema;

namespace BDEscuela.Models
{
    public class Carrera
    {
        public int CarreraId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }
    }
}
