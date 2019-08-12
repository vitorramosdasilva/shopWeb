using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shopWeb.Models
{
    [Table("itenspedidos")]
    public partial class Itenspedidos
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("idproduto")]
        public int Idproduto { get; set; }
        [Column("idpedido")]
        public int Idpedido { get; set; }
        [Column("quantidade")]
        public int Quantidade { get; set; }

        [ForeignKey("Idpedido")]
        [InverseProperty("Itenspedidos")]
        public virtual Pedidos IdpedidoNavigation { get; set; }
        [ForeignKey("Idproduto")]
        [InverseProperty("Itenspedidos")]
        public virtual Produtos IdprodutoNavigation { get; set; }
    }
}
