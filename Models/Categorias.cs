using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shopWeb.Models
{
    [Table("categorias")]
    public partial class Categorias
    {
        public Categorias()
        {
            Produtos = new HashSet<Produtos>();
        }

        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("descricao", TypeName = "character varying")]
        public string Descricao { get; set; }

        [InverseProperty("IdcategoriaNavigation")]
        public virtual ICollection<Produtos> Produtos { get; set; }
    }
}
