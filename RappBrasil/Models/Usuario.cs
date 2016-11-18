using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RappBrasil.Models
{
    public class Usuario
    {
        public int Cod_Usuario { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório"), StringLength(150)]
        public string Nome { get; set; }

        [StringLength(20), Phone]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório"), StringLength(150), EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório"), StringLength(50)]
        public string Empresa { get; set; }
    }
}