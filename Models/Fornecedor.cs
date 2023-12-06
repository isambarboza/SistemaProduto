using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SistemaProduto.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Column("Id")]
        [Display(Name = "Cód. Fornecedor")]
        public int Id { get; set; }

        [Column("FornecedorNome")]
        [Display(Name = "Nome Do Fornecedor")]
        public string FornecedorNome { get; set; } = string.Empty;


        [Column("EmailDoFornecedor")]
        [Display(Name = "E-mail Do Fornecedor")]
        public string EmailDoFornecedor { get; set; } = string.Empty;

        [Column("CnpjDoFornecedor")]
        [Display(Name = "CNPJ Do Fornecedor")]
        public string CnpjDoFornecedor { get; set; } = string.Empty;
    }
}
