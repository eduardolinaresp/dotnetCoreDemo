using ConsoleTestCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleTestCore.DAL
{
    
    public class StudentDAL
    {
        private BDContext db = new BDContext();
        private Student o_user = null;

        public Student Read(string p_user)
        {

            try
            {
                o_user = db.Students.FirstOrDefault(c => c.IdStudent == p_user);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return o_user;  
        }
    }
}
