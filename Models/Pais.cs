using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SistemaProduto.Models
{
    [Table("Pais")]
    public class Pais
    {
        [Column("Id")]
        [Display(Name = "Cód Pais")]
        public int Id { get; set; }

        [Column("PaisNome")]
        [Display(Name = "Nome Do País")]
        public string PaisNome { get; set; } = string.Empty;
    }
}