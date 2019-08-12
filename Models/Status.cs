using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shopWeb.Models
{
    [Table("status")]
    public partial class Status
    {
        public Status()
        {
            Pedidos = new HashSet<Pedidos>();
        }

        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("situacao", TypeName = "character varying")]
        public string Situacao { get; set; }

        [InverseProperty("IdstatusNavigation")]
        public virtual ICollection<Pedidos> Pedidos { get; set; }
    }
}
