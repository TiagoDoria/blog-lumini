using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LuminiBlog.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo 'Titulo' é obrigatório.")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Campo 'Resumo' é obrigatório.")]
        public string Resumo { get; set; }
        [Required(ErrorMessage = "Campo 'Texto' é obrigatório.")]
        public string Texto { get; set; }
        public DateTime Data { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
