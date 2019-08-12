using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using shopWeb.Models;

namespace shopWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<shopWeb.Models.Categorias> Categorias { get; set; }
        public DbSet<shopWeb.Models.Clientes> Clientes { get; set; }
        public DbSet<shopWeb.Models.Administradores> Administradores { get; set; }
        public DbSet<shopWeb.Models.Cidades> Cidades { get; set; }
        public DbSet<shopWeb.Models.Formapagamentos> Formapagamentos { get; set; }
        public DbSet<shopWeb.Models.Itenspedidos> Itenspedidos { get; set; }
        public DbSet<shopWeb.Models.Pedidos> Pedidos { get; set; }
        public DbSet<shopWeb.Models.Produtos> Produtos { get; set; }
        public DbSet<shopWeb.Models.Status> Status { get; set; }
    }
}
