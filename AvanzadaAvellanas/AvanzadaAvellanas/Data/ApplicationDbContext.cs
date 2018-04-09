using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AvanzadaAvellanas.Models;

namespace AvanzadaAvellanas.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> Personas { get; set; }
        public DbSet<TipoPersona> TipoPersona { get; set; }

        public DbSet<PersonaPorTipo> PersonaPorTipo { get; set; }
        //public DbSet<TipoPorPersona> TipoPorPersona { get; set; }


        public DbSet<Carreras> Carreras { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Carreras_Cursos> Carreras_Cursos { get; set; }

        //public DbSet<TipoPersona_Carreras> TipoPersona_Carreras { get; set; }


        public DbSet<Grupo> Grupos{ get; set; }
        public DbSet<Matricula> Matricula { get; set; }
        //public DbSet<PersonasGrupos> Personas_Por_Grupo { get; set; }



        public DbSet<Asistencia_Estudiante> Asistencia_Estudiantes { get; set; }
        public DbSet<Asistencia_Profesor> Asistencia_Profesores { get; set; }
        public DbSet<Rubros> Rubros { get; set; }
        public DbSet<Notas> Notas { get; set; }
        public DbSet<NotasRubrosPorPersona> Notas_Rubros_Persona { get; set; }
        public DbSet<RubrosPorGrupo> Rubros_Por_Grupo { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            

            builder.Entity<PersonaPorTipo>()
                .HasKey(t => new { t.ApplicationUserId, t.TipoPersonaId});

            builder.Entity<Carreras_Cursos>()
                .HasKey(c => new { c.CarreraId, c.CursoId });

            builder.Entity<Curso>()
                .HasMany(g => g.Grupos)
                .WithOne(c => c.Curso);
            
            builder.Entity<Grupo>()
                .HasMany(u => u.Persona)
                .WithOne(g => g.Grupo);

            builder.Entity<Matricula>()
                .HasMany(c => c.Cursos)
                .WithOne(m => m.Matricula);

            builder.Entity<Matricula>()
                .HasOne(p => p.PersonaPorTipo)
                .WithOne(m => m.Matricula);




            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);


        }
    }
}
