using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleTestCore.Models
{
    [Table("TblStudents")]
    public class Student
    {
        [Key]
        public int NroStudent { get; set; }
        public string IdStudent { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Clase { get; set; }

    }
}
