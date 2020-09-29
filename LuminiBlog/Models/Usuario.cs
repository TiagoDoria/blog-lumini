using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LuminiBlog.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo 'Nome' é obrigatório.")]
        public string Nome { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Campo 'E-mail' é obrigatório.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo 'Senha' é obrigatório.")]
        public string Senha { get; set; }
    }
}
