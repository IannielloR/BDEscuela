using BDEscuela.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BDEscuela.Data
{
    public class DbEscuelaContext: DbContext
    {
        public DbEscuelaContext(DbContextOptions<DbEscuelaContext> options) : base(options) { }

        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Curso> Curso { get; set; }

        public DbSet<Detalle> Detalles { get; set; }

        public DbSet<Estado> Estados { get; set; }

        public DbSet<Estudiante> Estudiantes { get; set; }

        public DbSet<Evaluacion> Evaluaciones { get; set; }

        public DbSet<Localidad> Localidades { get; set; }

        public DbSet<Materia> Materias { get; set; }

        public DbSet<Plan> Planes { get; set; }

        public DbSet<Planilla> Planillas { get; set; }

        public DbSet<Profesor> Profesores { get; set; }

        public DbSet<Tipo> Tipos { get; set; }


    }
}
