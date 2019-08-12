using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shopWeb.Models
{
    [Table("administradores")]
    public partial class Administradores
    {
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("nome", TypeName = "character varying")]
        public string Nome { get; set; }
        [Required]
        [Column("login", TypeName = "character varying")]
        public string Login { get; set; }
        [Required]
        [Column("senha", TypeName = "character varying")]
        public string Senha { get; set; }
    }
}
