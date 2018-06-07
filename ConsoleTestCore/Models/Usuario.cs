using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleTestCore.Models
{
    [Table("TblUsuarios")]
    public class Usuario
    {
        [Key]
        public int NroUsuario { get; set; }
        public string IdUsuario { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Clase { get; set; }

    }
}
