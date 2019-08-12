using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shopWeb.Models
{
    [Table("clientes")]
    public partial class Clientes
    {
        public Clientes()
        {
            Pedidos = new HashSet<Pedidos>();
        }

        [Column("id")]
        public int Id { get; set; }
        [Column("idcidade")]
        public int Idcidade { get; set; }
        [Required]
        [Column("nome", TypeName = "character varying")]
        public string Nome { get; set; }
        [Required]
        [Column("email")]
        public string Email { get; set; }
        [Required]
        [Column("cpf", TypeName = "character varying")]
        public string Cpf { get; set; }
        [Column("rg")]
        public int Rg { get; set; }
        [Column("datanasc", TypeName = "date")]
        public DateTime Datanasc { get; set; }
        [Column("fone")]
        public int Fone { get; set; }
        [Required]
        [Column("login", TypeName = "character varying")]
        public string Login { get; set; }
        [Required]
        [Column("senha", TypeName = "character varying")]
        public string Senha { get; set; }
        [Required]
        [Column("logradouro", TypeName = "character varying")]
        public string Logradouro { get; set; }
        [Column("cep")]
        public int Cep { get; set; }
        [Required]
        [Column("bairro", TypeName = "character varying")]
        public string Bairro { get; set; }
        [Column("numero")]
        public int? Numero { get; set; }

        [ForeignKey("Idcidade")]
        [InverseProperty("Clientes")]
        public virtual Cidades IdcidadeNavigation { get; set; }
        [InverseProperty("IdclienteNavigation")]
        public virtual ICollection<Pedidos> Pedidos { get; set; }
    }
}
