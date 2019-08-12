using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shopWeb.Models
{
    [Table("formapagamentos")]
    public partial class Formapagamentos
    {
        public Formapagamentos()
        {
            Pedidos = new HashSet<Pedidos>();
        }

        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("descricao", TypeName = "character varying")]
        public string Descricao { get; set; }

        [InverseProperty("IdformapagNavigation")]
        public virtual ICollection<Pedidos> Pedidos { get; set; }
    }
}
