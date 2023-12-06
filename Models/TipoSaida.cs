using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace SistemaProduto.Models
{
    [Table("TipoSaida")]
    public class TipoSaida
    {

        [Column("Id")]
        [Display(Name = "Cód.Tipo Saida")]
        public int Id { get; set; }

        [Column("TipoSaidaDescricao")]
        [Display(Name = "Nome Da Descrição")]
        public string TipoSaidaDescricao { get; set; } = string.Empty;
    }
}
