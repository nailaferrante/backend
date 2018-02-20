﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using modelobasicoefjwt.Repositorio;
using System;

namespace modelobasicoefjwt.Migrations
{
    [DbContext(typeof(AutenticacaoContext))]
    [Migration("20180209210725_Estrutura_Inicial")]
    partial class Estrutura_Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("modelobasicoefjwt.Models.Permissao", b =>
                {
                    b.Property<int>("IdPermissao")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("IdPermissao");

                    b.ToTable("Permissoes");
                });

            modelBuilder.Entity("modelobasicoefjwt.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("modelobasicoefjwt.Models.UsuarioPermissao", b =>
                {
                    b.Property<int>("IdUsuarioPermissao")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdPermissao");

                    b.Property<int>("IdUsuario");

                    b.HasKey("IdUsuarioPermissao");

                    b.HasIndex("IdPermissao");

                    b.HasIndex("IdUsuario");

                    b.ToTable("UsuariosPermissoes");
                });

            modelBuilder.Entity("modelobasicoefjwt.Models.UsuarioPermissao", b =>
                {
                    b.HasOne("modelobasicoefjwt.Models.Permissao", "Permissao")
                        .WithMany("UsuariosPermissoes")
                        .HasForeignKey("IdPermissao")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("modelobasicoefjwt.Models.Usuario", "Usuario")
                        .WithMany("UsuariosPermissoes")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
