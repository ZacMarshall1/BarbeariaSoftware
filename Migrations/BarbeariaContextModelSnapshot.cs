﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace TarefasApi.Migrations
{
    [DbContext(typeof(BarbeariaContext))]
    partial class BarbeariaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Agendamento", b =>
                {
                    b.Property<DateTime>("DataHoraAgendamento")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdAgendamento")
                        .HasColumnType("int");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdFuncionario")
                        .HasColumnType("int");

                    b.Property<int>("IdServico")
                        .HasColumnType("int");

                    b.Property<string>("Observacao")
                        .HasColumnType("longtext");

                    b.ToTable("Agendamentos");
                });

            modelBuilder.Entity("Cliente", b =>
                {
                    b.Property<string>("CPF")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Funcionario", b =>
                {
                    b.Property<string>("CPF")
                        .HasColumnType("longtext");

                    b.Property<string>("Cargo")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataAdmissao")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdFuncionario")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("Servico", b =>
                {
                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<int>("Duracao")
                        .HasColumnType("int");

                    b.Property<int>("IdServico")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.ToTable("Servicos");
                });
#pragma warning restore 612, 618
        }
    }
}
