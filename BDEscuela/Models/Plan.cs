using System.ComponentModel.DataAnnotations.Schema;

namespace BDEscuela.Models
{
    public class Plan
    {
        public int PlanId { get; set; }

        public int CarreraId { get; set; }
        [ForeignKey("CarreraId")]
        public Carrera Carrera { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }
    }
}
