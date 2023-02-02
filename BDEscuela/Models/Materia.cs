using System.ComponentModel.DataAnnotations.Schema;

namespace BDEscuela.Models
{
    public class Materia
    {
        public int MateriaId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Nombre { get;set; }
    }
}
