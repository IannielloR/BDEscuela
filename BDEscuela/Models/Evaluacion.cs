using System.ComponentModel.DataAnnotations.Schema;

namespace BDEscuela.Models
{
    public class Evaluacion
    {
        public int EvaluacionId { get; set; }

        public int TipoId { get; set; }
        [ForeignKey("TipoId")]
        public Tipo Tipo { get; set; }
        public int EstudiantedId { get; set; }
        [ForeignKey("EstudianteId")]
        public Estudiante Estudiante { get; set; }
        public int DetalleId { get; set; }
        [ForeignKey("DetalleId")]
        public Detalle Detalle { get; set; }

        public double Nota { get; set; }
        
    }
}
