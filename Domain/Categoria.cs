using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public long CategoriaId { get; set; }

        [Required(ErrorMessage ="Campo obrigatório!")]
        public string Nome { get; set; }

        public Categoria()
        {
            
        }
    }
}
