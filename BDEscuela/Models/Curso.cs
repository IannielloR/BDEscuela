using System.ComponentModel.DataAnnotations.Schema;

namespace BDEscuela.Models
{
    public class Curso
    {
        public int CursoId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set;}
    }
}
