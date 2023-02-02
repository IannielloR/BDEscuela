using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BDEscuela.Models
{
    public class Planilla
    {
        public int PlanillaId { get; set; }
        public int CarreraId { get; set; }
        [ForeignKey("CarreraId")]
        public Carrera Carrera { get; set; }

        public int MateriaId { get; set; }
        [ForeignKey("MateriaId")]
        public Materia Materia { get; set; }

        public int ProfesorId { get; set; }
        [ForeignKey("ProfesorId")]
        public Profesor Profesor { get; set; }

        public int CursoId { get; set; }
        [ForeignKey("CursoId")]
        public Curso Curso { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }
    }
}
