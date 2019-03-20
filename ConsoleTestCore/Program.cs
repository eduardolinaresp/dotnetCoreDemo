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
            
            try
            {
                UsuarioDAL _UserDAL = new UsuarioDAL();

                Usuario User = _UserDAL.Read("ADMIN");

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
