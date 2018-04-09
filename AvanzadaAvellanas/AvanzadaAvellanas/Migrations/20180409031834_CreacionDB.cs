using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AvanzadaAvellanas.Migrations
{
    public partial class CreacionDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asistencia_Profesores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Fecha_Ingreso = table.Column<DateTime>(nullable: false),
                    Fecha_Salida = table.Column<DateTime>(nullable: false),
                    Profesor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistencia_Profesores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carreras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre_Carrera = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rubros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NombreRubro = table.Column<string>(nullable: true),
                    Porcentaje = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rubros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPersona",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPersona", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    CursoId = table.Column<int>(nullable: false),
                    CursoId1 = table.Column<string>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    GrupoId = table.Column<int>(nullable: false),
                    Nota = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Apellido = table.Column<string>(nullable: true),
                    Carne = table.Column<int>(nullable: false),
                    Cedula = table.Column<int>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    NotasId = table.Column<int>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    Sexo = table.Column<int>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Notas_NotasId",
                        column: x => x.NotasId,
                        principalTable: "Notas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonaPorTipo",
                columns: table => new
                {
                    ApplicationUserId = table.Column<string>(nullable: false),
                    TipoPersonaId = table.Column<int>(nullable: false),
                    CarreraId = table.Column<int>(nullable: false),
                    CarrerasId = table.Column<int>(nullable: true),
                    CursoId = table.Column<int>(nullable: false),
                    CursoId1 = table.Column<string>(nullable: true),
                    GrupoId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    MatriculaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaPorTipo", x => new { x.ApplicationUserId, x.TipoPersonaId });
                    table.ForeignKey(
                        name: "FK_PersonaPorTipo_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonaPorTipo_Carreras_CarrerasId",
                        column: x => x.CarrerasId,
                        principalTable: "Carreras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonaPorTipo_TipoPersona_TipoPersonaId",
                        column: x => x.TipoPersonaId,
                        principalTable: "TipoPersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carreras_Cursos",
                columns: table => new
                {
                    CarreraId = table.Column<int>(nullable: false),
                    CursoId = table.Column<int>(nullable: false),
                    CarrerasId = table.Column<int>(nullable: true),
                    CursoId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras_Cursos", x => new { x.CarreraId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_Carreras_Cursos_Carreras_CarrerasId",
                        column: x => x.CarrerasId,
                        principalTable: "Carreras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Matricula",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarreraId = table.Column<int>(nullable: false),
                    CreditosMatriculados = table.Column<int>(nullable: false),
                    GrupoId = table.Column<int>(nullable: true),
                    MontoTotal = table.Column<int>(nullable: false),
                    Online = table.Column<int>(nullable: false),
                    PersonaPorTipoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matricula", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matricula_Carreras_CarreraId",
                        column: x => x.CarreraId,
                        principalTable: "Carreras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Creditos = table.Column<int>(nullable: false),
                    CursoId = table.Column<string>(nullable: true),
                    Estado = table.Column<int>(nullable: false),
                    MatriculaId = table.Column<int>(nullable: false),
                    Nombre_Curso = table.Column<string>(nullable: true),
                    Precio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cursos_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cursos_Matricula_MatriculaId",
                        column: x => x.MatriculaId,
                        principalTable: "Matricula",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CursoId = table.Column<int>(nullable: false),
                    CursoId1 = table.Column<string>(nullable: true),
                    Horario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grupos_Cursos_CursoId1",
                        column: x => x.CursoId1,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notas_Rubros_Persona",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CursoId = table.Column<string>(nullable: true),
                    NotasId = table.Column<int>(nullable: true),
                    PersonaId = table.Column<int>(nullable: true),
                    RubrosId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas_Rubros_Persona", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notas_Rubros_Persona_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notas_Rubros_Persona_Notas_NotasId",
                        column: x => x.NotasId,
                        principalTable: "Notas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notas_Rubros_Persona_TipoPersona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "TipoPersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notas_Rubros_Persona_Rubros_RubrosId",
                        column: x => x.RubrosId,
                        principalTable: "Rubros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Asistencia_Estudiantes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Asistencia = table.Column<int>(nullable: false),
                    Comentarios = table.Column<string>(nullable: true),
                    CursoId = table.Column<int>(nullable: false),
                    CursoId1 = table.Column<string>(nullable: true),
                    EstudianteId = table.Column<int>(nullable: false),
                    FechaAsistencia = table.Column<DateTime>(nullable: false),
                    GrupoId = table.Column<int>(nullable: false),
                    ProfesorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistencia_Estudiantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asistencia_Estudiantes_Cursos_CursoId1",
                        column: x => x.CursoId1,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asistencia_Estudiantes_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rubros_Por_Grupo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarreraId = table.Column<int>(nullable: false),
                    CursoId = table.Column<int>(nullable: false),
                    CursoId1 = table.Column<string>(nullable: true),
                    GrupoId = table.Column<int>(nullable: false),
                    RubroId = table.Column<int>(nullable: false),
                    RubrosId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rubros_Por_Grupo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rubros_Por_Grupo_Carreras_CarreraId",
                        column: x => x.CarreraId,
                        principalTable: "Carreras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rubros_Por_Grupo_Cursos_CursoId1",
                        column: x => x.CursoId1,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rubros_Por_Grupo_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rubros_Por_Grupo_Rubros_RubrosId",
                        column: x => x.RubrosId,
                        principalTable: "Rubros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asistencia_Estudiantes_CursoId1",
                table: "Asistencia_Estudiantes",
                column: "CursoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencia_Estudiantes_GrupoId",
                table: "Asistencia_Estudiantes",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NotasId",
                table: "AspNetUsers",
                column: "NotasId");

            migrationBuilder.CreateIndex(
                name: "IX_Carreras_Cursos_CarrerasId",
                table: "Carreras_Cursos",
                column: "CarrerasId");

            migrationBuilder.CreateIndex(
                name: "IX_Carreras_Cursos_CursoId1",
                table: "Carreras_Cursos",
                column: "CursoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_CursoId",
                table: "Cursos",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_MatriculaId",
                table: "Cursos",
                column: "MatriculaId");

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_CursoId1",
                table: "Grupos",
                column: "CursoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Matricula_CarreraId",
                table: "Matricula",
                column: "CarreraId");

            migrationBuilder.CreateIndex(
                name: "IX_Matricula_GrupoId",
                table: "Matricula",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_ApplicationUserId",
                table: "Notas",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_CursoId1",
                table: "Notas",
                column: "CursoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_GrupoId",
                table: "Notas",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_Rubros_Persona_CursoId",
                table: "Notas_Rubros_Persona",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_Rubros_Persona_NotasId",
                table: "Notas_Rubros_Persona",
                column: "NotasId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_Rubros_Persona_PersonaId",
                table: "Notas_Rubros_Persona",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_Rubros_Persona_RubrosId",
                table: "Notas_Rubros_Persona",
                column: "RubrosId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaPorTipo_CarrerasId",
                table: "PersonaPorTipo",
                column: "CarrerasId",
                unique: true,
                filter: "[CarrerasId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaPorTipo_CursoId1",
                table: "PersonaPorTipo",
                column: "CursoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaPorTipo_GrupoId",
                table: "PersonaPorTipo",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaPorTipo_MatriculaId",
                table: "PersonaPorTipo",
                column: "MatriculaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonaPorTipo_TipoPersonaId",
                table: "PersonaPorTipo",
                column: "TipoPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rubros_Por_Grupo_CarreraId",
                table: "Rubros_Por_Grupo",
                column: "CarreraId");

            migrationBuilder.CreateIndex(
                name: "IX_Rubros_Por_Grupo_CursoId1",
                table: "Rubros_Por_Grupo",
                column: "CursoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Rubros_Por_Grupo_GrupoId",
                table: "Rubros_Por_Grupo",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Rubros_Por_Grupo_RubrosId",
                table: "Rubros_Por_Grupo",
                column: "RubrosId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Cursos_CursoId1",
                table: "Notas",
                column: "CursoId1",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Grupos_GrupoId",
                table: "Notas",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_AspNetUsers_ApplicationUserId",
                table: "Notas",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonaPorTipo_Cursos_CursoId1",
                table: "PersonaPorTipo",
                column: "CursoId1",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonaPorTipo_Grupos_GrupoId",
                table: "PersonaPorTipo",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonaPorTipo_Matricula_MatriculaId",
                table: "PersonaPorTipo",
                column: "MatriculaId",
                principalTable: "Matricula",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carreras_Cursos_Cursos_CursoId1",
                table: "Carreras_Cursos",
                column: "CursoId1",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Grupos_GrupoId",
                table: "Matricula",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_Cursos_CursoId1",
                table: "Grupos");

            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Cursos_CursoId1",
                table: "Notas");

            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Grupos_GrupoId",
                table: "Notas");

            migrationBuilder.DropForeignKey(
                name: "FK_Notas_AspNetUsers_ApplicationUserId",
                table: "Notas");

            migrationBuilder.DropTable(
                name: "Asistencia_Estudiantes");

            migrationBuilder.DropTable(
                name: "Asistencia_Profesores");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Carreras_Cursos");

            migrationBuilder.DropTable(
                name: "Notas_Rubros_Persona");

            migrationBuilder.DropTable(
                name: "PersonaPorTipo");

            migrationBuilder.DropTable(
                name: "Rubros_Por_Grupo");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "TipoPersona");

            migrationBuilder.DropTable(
                name: "Rubros");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Matricula");

            migrationBuilder.DropTable(
                name: "Carreras");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Notas");
        }
    }
}
