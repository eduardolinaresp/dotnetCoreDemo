using ConsoleTestCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleTestCore.DAL
{
    
    public class UsuarioDAL
    {
        private BDContext db = new BDContext();
        private Usuario o_user = null;

        public Usuario Read(string p_user)
        {

            try
            {
                o_user = db.Usuarios.FirstOrDefault(c => c.IdUsuario == p_user);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return o_user;  
        }
    }
}
