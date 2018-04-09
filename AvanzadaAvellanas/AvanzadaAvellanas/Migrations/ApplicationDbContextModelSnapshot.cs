﻿// <auto-generated />
using AvanzadaAvellanas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AvanzadaAvellanas.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AvanzadaAvellanas.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Apellido");

                    b.Property<int>("Carne");

                    b.Property<int>("Cedula");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Nombre");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<int?>("NotasId");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<int>("Sexo");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("NotasId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("AvanzadaAvellanas.Models.Asistencia_Estudiante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Asistencia");

                    b.Property<string>("Comentarios");

                    b.Property<int>("CursoId");

                    b.Property<string>("CursoId1");

                    b.Property<int>("EstudianteId");

                    b.Property<DateTime>("FechaAsistencia");

                    b.Property<int>("GrupoId");

                    b.Property<int>("ProfesorId");

                    b.HasKey("Id");

                    b.HasIndex("CursoId1");

                    b.HasIndex("GrupoId");

                    b.ToTable("Asistencia_Estudiantes");
                });

            modelBuilder.Entity("AvanzadaAvellanas.Models.Asistencia_Profesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Fecha_Ingreso");

                    b.Property<DateTime>("Fecha_Salida");

                    b.Property<int>("Profesor");

                    b.HasKey("Id");

                    b.ToTable("Asistencia_Profesores");
                });

            modelBuilder.Entity("AvanzadaAvellanas.Models.Carreras", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre_Carrera");

                    b.HasKey("Id");

                    b.ToTable("Carreras");
                });

            modelBuilder.Entity("AvanzadaAvellanas.Models.Carreras_Cursos", b =>
                {
                    b.Property<int>("CarreraId");

                    b.Property<int>("CursoId");

                    b.Property<int?>("CarrerasId");

                    b.Property<string>("CursoId1");

                    b.HasKey("CarreraId", "CursoId");

                    b.HasIndex("CarrerasId");

                    b.HasIndex("CursoId1");

                    b.ToTable("Carreras_Cursos");
                });

            modelBuilder.Entity("AvanzadaAvellanas.Models.Curso", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Creditos");

                    b.Property<string>("CursoId");

                    b.Property<int>("Estado");

                    b.Property<int>("MatriculaId");

                    b.Property<string>("Nombre_Curso");

                    b.Property<int>("Precio");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("MatriculaId");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("AvanzadaAvellanas.Models.Grupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CursoId");

                    b.Property<string>("CursoId1");

                    b.Property<int>("Horario");

                    b.HasKey("Id");

                    b.HasIndex("CursoId1");

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("AvanzadaAvellanas.Models.Matricula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CarreraId");

                    b.Property<int>("CreditosMatriculados");

                    b.Property<int?>("GrupoId");

                    b.Property<int>("MontoTotal");

                    b.Property<int>("Online");

                    b.Property<int>("PersonaPorTipoId");

                    b.HasKey("Id");

                    b.HasIndex("CarreraId");

                    b.HasIndex("GrupoId");

                    b.ToTable("Matricula");
                });

            modelBuilder.Entity("AvanzadaAvellanas.Models.Notas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<int>("CursoId");

                    b.Property<string>("CursoId1");

                    b.Property<DateTime>("Fecha");

                    b.Property<int>("GrupoId");

                    b.Property<int>("Nota");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("CursoId1");

                    b.HasIndex("GrupoId");

                    b.ToTable("Notas");
                });

            modelBuilder.Entity("AvanzadaAvellanas.Models.NotasRubrosPorPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CursoId");

                    b.Property<int?>("NotasId");

                    b.Property<int?>("PersonaId");

                    b.Property<int?>("RubrosId");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("NotasId");

                    b.HasIndex("PersonaId");

                    b.HasIndex("RubrosId");

                    b.ToTable("Notas_Rubros_Persona");
                });

            modelBuilder.Entity("AvanzadaAvellanas.Models.PersonaPorTipo", b =>
                {
                    b.Property<string>("ApplicationUserId");

                    b.Property<int>("TipoPersonaId");

                    b.Property<int>("CarreraId");

                    b.Property<int?>("CarrerasId");

                    b.Property<int>("CursoId");

                    b.Property<string>("CursoId1");

                    b.Property<int>("GrupoId");

                    b.Property<int>("Id");

                    b.Property<int>("MatriculaId");

                    b.HasKey("ApplicationUserId", "TipoPersonaId");

                    b.HasIndex("CarrerasId")
                        .IsUnique()
                        .HasFilter("[CarrerasId] IS NOT NULL");

                    b.HasIndex("CursoId1");

                    b.HasIndex("GrupoId");

                    b.HasIndex("MatriculaId")
                        .IsUnique();

                    b.HasIndex("TipoPersonaId");

                    b.ToTable("PersonaPorTipo");
                });

            modelBuilder.Entity("AvanzadaAvellanas.Models.Rubros", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NombreRubro");

                    b.Property<int>("Porcentaje");

                    b.HasKey("Id");

                    b.ToTable("Rubros");
                });

            modelBuilder.Entity("AvanzadaAvellanas.Models.RubrosPorGrupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CarreraId");

                    b.Property<int>("CursoId");

                    b.Property<string>("CursoId1");

                    b.Property<int>("GrupoId");

                    b.Property<int>("RubroId");

                    b.Property<int?>("RubrosId");

                    b.HasKey("Id");

                    b.HasIndex("CarreraId");

                    b.HasIndex("CursoId1");

                    b.HasIndex("GrupoId");

                    b.HasIndex("RubrosId");

                    b.ToTable("Rubros_Por_Grupo");
                });

            modelBuilder.Entity("AvanzadaAvellanas.Models.TipoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("TipoPersona");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AvanzadaAvellanas.Models.ApplicationUser", b =>
                {
                    b.HasOne("AvanzadaAvellanas.Models.Notas")
                        .WithMany("ApplicationUsersId")
                        .HasForeignKey("NotasId");
                });

            modelBuilder.Entity("AvanzadaAvellanas.Models.Asistencia_Estudiante", b =>
                {
                    b.HasOne("AvanzadaAvellanas.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId1");

                    b.HasOne("AvanzadaAvellanas.Models.Grupo", "Grupo")
                        .WithMany()
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AvanzadaAvellanas.Models.Carreras_Cursos", b =>
                {
                    b.HasOne("AvanzadaAvellanas.Models.Carreras", "Carreras")
                        .WithMany("Cursos")
                        .HasForeignKey("CarrerasId");

                    b.HasOne("AvanzadaAvellanas.Models.Curso", "Curso")
                        .WithMany("Carreras")
                        .HasForeignKey("CursoId1");
                });

            modelBuilder.Entity("AvanzadaAvellanas.Models.Curso", b =>
                {
                    b.HasOne("AvanzadaAvellanas.Models.Curso")
                        .WithMany("Curso_Rquerido")
                        .HasForeignKey("CursoId");

                    b.HasOne("AvanzadaAvellanas.Models.Matricula", "Matricula")
                        .WithMany("Cursos")
                        .HasForeignKey("MatriculaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AvanzadaAvellanas.Models.Grupo", b =>
                {
                    b.HasOne("AvanzadaAvellanas.Models.Curso", "Curso")
                        .WithMany("Grupos")
                        .HasForeignKey("CursoId1");
                });

            modelBuilder.Entity("AvanzadaAvellanas.Models.Matricula", b =>
                {
                    b.HasOne("AvanzadaAvellanas.Models.Carreras", "Carrera")
                        .WithMany()
                        .HasForeignKey("CarreraId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AvanzadaAvellanas.Models.Grupo", "Grupo")
                        .WithMany()
                        .HasForeignKey("GrupoId");
                });

            modelBuilder.Entity("AvanzadaAvellanas.Models.Notas", b =>
                {
                    b.HasOne("AvanzadaAvellanas.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("AvanzadaAvellanas.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId1");

                    b.HasOne("AvanzadaAvellanas.Models.Grupo", "Grupo")
                        .WithMany()
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AvanzadaAvellanas.Models.NotasRubrosPorPersona", b =>
                {
                    b.HasOne("AvanzadaAvellanas.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId");

                    b.HasOne("AvanzadaAvellanas.Models.Notas", "Notas")
                        .WithMany()
                        .HasForeignKey("NotasId");

                    b.HasOne("AvanzadaAvellanas.Models.TipoPersona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId");

                    b.HasOne("AvanzadaAvellanas.Models.Rubros", "Rubros")
                        .WithMany()
                        .HasForeignKey("RubrosId");
                });

            modelBuilder.Entity("AvanzadaAvellanas.Models.PersonaPorTipo", b =>
                {
                    b.HasOne("AvanzadaAvellanas.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("TipoPersonas")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AvanzadaAvellanas.Models.Carreras", "Carreras")
                        .WithOne("Persona")
                        .HasForeignKey("AvanzadaAvellanas.Models.PersonaPorTipo", "CarrerasId");

                    b.HasOne("AvanzadaAvellanas.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId1");

                    b.HasOne("AvanzadaAvellanas.Models.Grupo", "Grupo")
                        .WithMany("Persona")
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AvanzadaAvellanas.Models.Matricula", "Matricula")
                        .WithOne("PersonaPorTipo")
                        .HasForeignKey("AvanzadaAvellanas.Models.PersonaPorTipo", "MatriculaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AvanzadaAvellanas.Models.TipoPersona", "TipoPersona")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("TipoPersonaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AvanzadaAvellanas.Models.RubrosPorGrupo", b =>
                {
                    b.HasOne("AvanzadaAvellanas.Models.Carreras", "Carrera")
                        .WithMany()
                        .HasForeignKey("CarreraId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AvanzadaAvellanas.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId1");

                    b.HasOne("AvanzadaAvellanas.Models.Grupo", "Grupo")
                        .WithMany()
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AvanzadaAvellanas.Models.Rubros", "Rubros")
                        .WithMany()
                        .HasForeignKey("RubrosId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AvanzadaAvellanas.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AvanzadaAvellanas.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AvanzadaAvellanas.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AvanzadaAvellanas.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
