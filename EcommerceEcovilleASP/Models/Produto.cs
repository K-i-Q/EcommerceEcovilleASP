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
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
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
            sb.Append("Preço: " + Preco.ToString("C2"));
            sb.Append("Quantidade: " + Quantidade);
            sb.Append("Criado em: " + CriadoEm);

            return base.ToString();
        }
    }
}
