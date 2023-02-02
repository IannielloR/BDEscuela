using System.ComponentModel.DataAnnotations.Schema;

namespace BDEscuela.Models
{
    public class Estado
    {
        public int EstadoId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }
    }
}
