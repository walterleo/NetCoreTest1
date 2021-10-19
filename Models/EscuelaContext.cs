using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Collections.Generic;

namespace NetCoreTest1.Models
{
    public class EscuelaContext: DbContext{

        public DbSet<Escuela> Escuelas{ get; set;}

        public DbSet<Asignatura> Asignaturas{ get; set;}

        public DbSet<Alumno> Alumnos{ get; set;}

        public DbSet<Curso> Cursos{ get; set;}

        public DbSet<Evaluación> Evaluaciones{ get; set;}

        public EscuelaContext(DbContextOptions<EscuelaContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);   
            
            var school = new Escuela();
            school.AñoDeCreación = 2005;
            school.Nombre = "Brisbane";
            school.Id = Guid.NewGuid().ToString();
            school.Ciudad= "Sydney";
            school.Pais= "Australia";
            school.TipoEscuela= TiposEscuela.Secundaria;

            modelBuilder.Entity<Escuela>().HasData(school);

            modelBuilder.Entity<Asignatura>().HasData(

                            new Asignatura{Nombre="Matemáticas",
                                Id= Guid.NewGuid().ToString()
                            } ,
                            new Asignatura{Nombre="Educación Física",
                                Id= Guid.NewGuid().ToString()
                            },
                            new Asignatura{Nombre="Castellano",
                                Id= Guid.NewGuid().ToString()
                            },
                            new Asignatura{Nombre="Ciencias Naturales",
                                Id= Guid.NewGuid().ToString()
                            }
                            ,
                            new Asignatura{Nombre="Programación",
                                Id= Guid.NewGuid().ToString()
                            }
            );

            modelBuilder.Entity<Alumno>().HasData(GenerarAlumnosAlAzar().ToArray());

        }

          private List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = {"Jose", "Maria", "Pepe", "Alba", "Keira", "Kat"};
            string[] apellido1 = {"Ruiz", "Maduro", "casa", "Aldaz", "Dump", "Burrow"};
            string[] nombre2 = {"Fabi", "Vale", "Lore", "Anastacia", "Key", "Katy"};

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno {
                                   Nombre =$"{n1} {n2} {a1}",
                                    Id = Guid.NewGuid().ToString()
                               };

                    return listaAlumnos.OrderBy((al) => al.Id).ToList();

        }
    }
}

