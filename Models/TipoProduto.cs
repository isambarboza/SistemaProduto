using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SistemaProduto.Models
{
    [Table("TipoProduto")]
    public class TipoProduto
    {

        [Column("Id")]
        [Display(Name = "Cód. Tipo Produto")]
        public int Id { get; set; }

        [Column("TipoProdutoDescricao")]
        [Display(Name = "Descrição Do Produto")]
        public string TipoProdutoDescricao { get; set; } = string.Empty;
    }
}
