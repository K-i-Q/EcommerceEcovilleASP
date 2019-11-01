using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public long UsuarioId { get; set; }

        [Display(Name = "E-mail:")]
        [EmailAddress]
        public string Email{ get; set; }

        [Display(Name = "Senha:")]
        public string Senha{ get; set; }
        [Display(Name = "Confirmar Senha:")]
        [NotMapped]
        [Compare("Senha",ErrorMessage ="Senhas não são iguais. Verifique.")]
        public string ConfirmacaoSenha{ get; set; }
        [Display(Name = "Endereço:")]
        public Endereco Endereco{ get; set; }

        public DateTime CriadoEm { get; set; }

        public Usuario()
        {
            CriadoEm = DateTime.Now;
            Endereco = new Endereco();
        }
    }
}
