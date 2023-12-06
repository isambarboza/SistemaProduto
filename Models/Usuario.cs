using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SistemaProduto.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("Id")]
        [Display(Name = "Codigo do Usuário")]

        public int Id { get; set; }

        [Column("UsuarioNome")]
        [Display(Name = "Nome Do Usuário")]

        public string UsuarioNome { get; set; } = string.Empty;

        [Column("UsuarioEmail")]
        [Display(Name = "E-mail Do Usuário")]

        public string UsuarioEmail { get; set; } = string.Empty;

        [Column("UsuarioSenha")]
        [Display(Name = "Senha Do Usuário")]

        public string UsuarioSenha { get; set; } = string.Empty;

    }
}
