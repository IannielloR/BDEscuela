using System.ComponentModel.DataAnnotations.Schema;

namespace BDEscuela.Models
{
    public class Tipo
    {
        public int TipoId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }
    }
}
