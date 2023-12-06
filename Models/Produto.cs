using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SistemaProduto.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Cód. Produto")]
        public int Id { get; set; }

        [Column("ProdutoNome")]
        [Display(Name = "Nome Do Produto")]
        public string ProdutoNome { get; set; } = string.Empty;

        [Column("ProdutoEstoque")]
        [Display(Name = "Quantidade Em Estoque")]
        public int ProdutoEstoque { get; set; }

        [ForeignKey("TipoProdutoId")]
        [Display(Name = "Tido Do Produto")]
        public int TipoProdutoId { get; set; }
        public TipoProduto? TipoProduto { get; set; }

        [ForeignKey("FornecedorId")]
        [Display(Name = "Fornecedor")]
        public int FornecedorId { get; set; }
        public Fornecedor? Fornecedor { get; set; }
    }
}
