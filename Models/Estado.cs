﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SistemaProduto.Models
{
    [Table("Estado")]
    public class Estado
    {
        [Column("Id")]
        [Display(Name = "Cód. Estado")]
        public int Id { get; set; }

        [Column("EstadoNome")]
        [Display(Name = "Nome Do Estado")]
        public string EstadoNome { get; set; } = string.Empty;

        [ForeignKey("PaisId")]
        [Display(Name = "País")]
        public int PaisId { get; set; }
        public Pais? Pais { get; set; }

    }
}