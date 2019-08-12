﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using shopWeb.Data;

namespace shopWeb.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190811222916_Cidades")]
    partial class Cidades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("shopWeb.Models.Administradores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnName("login")
                        .HasColumnType("character varying");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nome")
                        .HasColumnType("character varying");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnName("senha")
                        .HasColumnType("character varying");

                    b.HasKey("Id");

                    b.ToTable("administradores");
                });

            modelBuilder.Entity("shopWeb.Models.Categorias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("descricao")
                        .HasColumnType("character varying");

                    b.HasKey("Id");

                    b.ToTable("categorias");
                });

            modelBuilder.Entity("shopWeb.Models.Cidades", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("descricao")
                        .HasColumnType("character varying");

                    b.HasKey("Id");

                    b.ToTable("cidades");
                });

            modelBuilder.Entity("shopWeb.Models.Clientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnName("bairro")
                        .HasColumnType("character varying");

                    b.Property<int>("Cep")
                        .HasColumnName("cep");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnName("cpf")
                        .HasColumnType("character varying");

                    b.Property<DateTime>("Datanasc")
                        .HasColumnName("datanasc")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email");

                    b.Property<int>("Fone")
                        .HasColumnName("fone");

                    b.Property<int>("Idcidade")
                        .HasColumnName("idcidade");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnName("login")
                        .HasColumnType("character varying");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnName("logradouro")
                        .HasColumnType("character varying");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nome")
                        .HasColumnType("character varying");

                    b.Property<int?>("Numero")
                        .HasColumnName("numero");

                    b.Property<int>("Rg")
                        .HasColumnName("rg");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnName("senha")
                        .HasColumnType("character varying");

                    b.HasKey("Id");

                    b.HasIndex("Idcidade");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("shopWeb.Models.Formapagamentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("descricao")
                        .HasColumnType("character varying");

                    b.HasKey("Id");

                    b.ToTable("formapagamentos");
                });

            modelBuilder.Entity("shopWeb.Models.Itenspedidos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("Idpedido")
                        .HasColumnName("idpedido");

                    b.Property<int>("Idproduto")
                        .HasColumnName("idproduto");

                    b.Property<int>("Quantidade")
                        .HasColumnName("quantidade");

                    b.HasKey("Id");

                    b.HasIndex("Idpedido");

                    b.HasIndex("Idproduto");

                    b.ToTable("itenspedidos");
                });

            modelBuilder.Entity("shopWeb.Models.Pedidos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnName("data")
                        .HasColumnType("character varying");

                    b.Property<string>("Frete")
                        .IsRequired()
                        .HasColumnName("frete")
                        .HasColumnType("character varying");

                    b.Property<int>("Idcliente")
                        .HasColumnName("idcliente");

                    b.Property<int>("Idformapag")
                        .HasColumnName("idformapag");

                    b.Property<int>("Idstatus")
                        .HasColumnName("idstatus");

                    b.Property<string>("Total")
                        .IsRequired()
                        .HasColumnName("total")
                        .HasColumnType("character varying");

                    b.HasKey("Id");

                    b.HasIndex("Idcliente");

                    b.HasIndex("Idformapag");

                    b.HasIndex("Idstatus");

                    b.ToTable("pedidos");
                });

            modelBuilder.Entity("shopWeb.Models.Produtos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("descricao")
                        .HasColumnType("character varying");

                    b.Property<int>("Idcategoria")
                        .HasColumnName("idcategoria");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnName("imagem")
                        .HasColumnType("character varying");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nome")
                        .HasColumnType("character varying");

                    b.Property<decimal>("Preco")
                        .HasColumnName("preco")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("Idcategoria");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("shopWeb.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Situacao")
                        .IsRequired()
                        .HasColumnName("situacao")
                        .HasColumnType("character varying");

                    b.HasKey("Id");

                    b.ToTable("status");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("shopWeb.Models.Clientes", b =>
                {
                    b.HasOne("shopWeb.Models.Cidades", "IdcidadeNavigation")
                        .WithMany("Clientes")
                        .HasForeignKey("Idcidade")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("shopWeb.Models.Itenspedidos", b =>
                {
                    b.HasOne("shopWeb.Models.Pedidos", "IdpedidoNavigation")
                        .WithMany("Itenspedidos")
                        .HasForeignKey("Idpedido")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("shopWeb.Models.Produtos", "IdprodutoNavigation")
                        .WithMany("Itenspedidos")
                        .HasForeignKey("Idproduto")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("shopWeb.Models.Pedidos", b =>
                {
                    b.HasOne("shopWeb.Models.Clientes", "IdclienteNavigation")
                        .WithMany("Pedidos")
                        .HasForeignKey("Idcliente")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("shopWeb.Models.Formapagamentos", "IdformapagNavigation")
                        .WithMany("Pedidos")
                        .HasForeignKey("Idformapag")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("shopWeb.Models.Status", "IdstatusNavigation")
                        .WithMany("Pedidos")
                        .HasForeignKey("Idstatus")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("shopWeb.Models.Produtos", b =>
                {
                    b.HasOne("shopWeb.Models.Categorias", "IdcategoriaNavigation")
                        .WithMany("Produtos")
                        .HasForeignKey("Idcategoria")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
