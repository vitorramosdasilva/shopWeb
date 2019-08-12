using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shopWeb.Models
{
    [Table("cidades")]
    public partial class Cidades
    {
        public Cidades()
        {
            Clientes = new HashSet<Clientes>();
        }

        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("descricao", TypeName = "character varying")]
        public string Descricao { get; set; }

        [InverseProperty("IdcidadeNavigation")]
        public virtual ICollection<Clientes> Clientes { get; set; }
    }
}
