using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shopWeb.Models
{
    [Table("pedidos")]
    public partial class Pedidos
    {
        public Pedidos()
        {
            Itenspedidos = new HashSet<Itenspedidos>();
        }

        [Column("id")]
        public int Id { get; set; }
        [Column("idcliente")]
        public int Idcliente { get; set; }
        [Column("idformapag")]
        public int Idformapag { get; set; }
        [Required]
        [Column("frete", TypeName = "character varying")]
        public string Frete { get; set; }
        [Required]
        [Column("total", TypeName = "character varying")]
        public string Total { get; set; }
        [Column("idstatus")]
        public int Idstatus { get; set; }
        [Required]
        [Column("data", TypeName = "character varying")]
        public string Data { get; set; }

        [ForeignKey("Idcliente")]
        [InverseProperty("Pedidos")]
        public virtual Clientes IdclienteNavigation { get; set; }
        [ForeignKey("Idformapag")]
        [InverseProperty("Pedidos")]
        public virtual Formapagamentos IdformapagNavigation { get; set; }
        [ForeignKey("Idstatus")]
        [InverseProperty("Pedidos")]
        public virtual Status IdstatusNavigation { get; set; }
        [InverseProperty("IdpedidoNavigation")]
        public virtual ICollection<Itenspedidos> Itenspedidos { get; set; }
    }
}
