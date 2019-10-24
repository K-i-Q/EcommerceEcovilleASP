using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EcommerceEcovilleASP.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [Display(Name ="Nome:")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [MinLength(5, ErrorMessage = "No mínimo 5 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Descrição:")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [MinLength(5,ErrorMessage ="No mínimo 5 caracteres")]
        [MaxLength(20,ErrorMessage ="No máximo 20 caracteres")]
        public string Descricao { get; set; }

        [Display(Name = "Preço:")]
        [Range(1,1000, ErrorMessage = "O preço deve estar entre 1 e 1000")]
        public double? Preco { get; set; }

        [Display(Name = "Quantidade:")]
        [Range(1, 1000, ErrorMessage = "A quantidade deve estar entre 1 e 1000")]
        public int? Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }

        public Produto()
        {
            CriadoEm = DateTime.Now;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Id: " + ProdutoId);
            sb.Append("Nome: " + Nome);
            sb.Append("Descrição: " + Descricao);
            sb.Append("Preço: " + Preco.Value.ToString("C2"));
            sb.Append("Quantidade: " + Quantidade);
            sb.Append("Criado em: " + CriadoEm);

            return base.ToString();
        }
    }
}
