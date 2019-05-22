using CampusApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace CampusApp
{
    class Program
    {
               

     
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DesignTimeDbContextFactory p = new DesignTimeDbContextFactory();

            using (var context = p.CreateDbContext(null))
            {
                string apellido;

                do
                {
                    Console.WriteLine("Digite apellido del alumno!");
                    apellido = Console.ReadLine();

                    if (!string.IsNullOrEmpty(apellido))
                    {
                        break;
                    }
                    

                } while (true);

                

                var param = new SqlParameter("@LastName", apellido);

                string mensaje = "Sin resultados"; 
                foreach (var item in context.Students.FromSql("GetStudents @LastName", param).ToList())
                {
                    mensaje = null;
                    Console.WriteLine(string.Format("Alumno(s) encontrado(s) {0},{1}", item.LastName, item.FirstMidName));
                }

                foreach (var item in context.Instructors.ToList())
                {

                    Console.WriteLine(string.Format("Profesores en BD {0},{1}", item.FirstName, item.LastName));
                }
                Console.WriteLine(mensaje);
                Console.WriteLine("Presione una tecla para salir");
                Console.ReadKey();
            }
        }

       
    }
}
