using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SistemaProduto.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Cód. Cliente")]
        public int Id { get; set; }

        [Column("ClienteNome")]
        [Display(Name = "Nome Do Cliente")]
        public string ClienteNome { get; set; } = string.Empty;

        [Column("DataSDeNascimento")]
        [Display(Name = "Data De Nascimento")]
        public DateTime DataSDeNascimento { get; set; }

        [Column("CpfCliente")]
        [Display(Name = "CPF Do Cliente")]
        public string CpfCliente { get; set; } = string.Empty;

        [Column("EnderecoCliente")]
        [Display(Name = "Endereço Do Cliente")]
        public string EnderecoCliente { get; set; } = string.Empty;

        [Column("NumeroCasaCliente")]
        [Display(Name = "Número Da Casa")]
        public string NumeroCasaCliente { get; set; } = string.Empty;

        [Column("BairroCliente")]
        [Display(Name = "Bairro")]
        public string BairroCliente { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        [Display(Name = "Cidade")]
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }

        [Column("TelefoneCliente")]
        [Display(Name = "Número De Telefone")]
        public string TelefoneCliente { get; set; } = string.Empty;


    }
}
