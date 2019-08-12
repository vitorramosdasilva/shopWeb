using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shopWeb.Models
{
    [Table("produtos")]
    public partial class Produtos
    {
        public Produtos()
        {
            Itenspedidos = new HashSet<Itenspedidos>();
        }

        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("descricao", TypeName = "character varying")]
        public string Descricao { get; set; }
        [Column("preco", TypeName = "numeric")]
        public decimal Preco { get; set; }
        [Required]
        [Column("imagem", TypeName = "character varying")]
        public string Imagem { get; set; }
        [Required]
        [Column("nome", TypeName = "character varying")]
        public string Nome { get; set; }
        [Column("idcategoria")]
        public int Idcategoria { get; set; }

        [ForeignKey("Idcategoria")]
        [InverseProperty("Produtos")]
        public virtual Categorias IdcategoriaNavigation { get; set; }
        [InverseProperty("IdprodutoNavigation")]
        public virtual ICollection<Itenspedidos> Itenspedidos { get; set; }
    }
}
