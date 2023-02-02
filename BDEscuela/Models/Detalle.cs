using System.ComponentModel.DataAnnotations.Schema;

namespace BDEscuela.Models
{
    public class Detalle
    {
        public int DetalleId { get; set; }

        public int PlanillaId { get; set; }
        [ForeignKey("PlanillaId")]
        public Planilla Planilla { get; set; }

        public int EstadoId { get; set; }
        [ForeignKey("EstadoId")]
        public Estado Estado { get; set; }
    }
}
