using ConsoleTestCore.DAL;
using ConsoleTestCore.Models;
using System;

namespace ConsoleTestCore
{
    class Program
    {
        
       static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Ejecutar Migraciones!");

            try
            {
                StudentDAL _UserDAL = new StudentDAL();

                Student User = _UserDAL.Read("ADMIN");

                Console.WriteLine(User.Nombre);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }

            Console.ReadKey();

        }

    
    }
}
