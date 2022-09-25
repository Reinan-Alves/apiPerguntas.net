﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizAngular.Data;

namespace QuizAngular.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220925172227_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("QuizAngular.Data.Pergunta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("liberada")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("resposta")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("texto")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("id");

                    b.ToTable("Perguntas");

                    b.HasData(
                        new
                        {
                            id = 1,
                            liberada = true,
                            resposta = "5",
                            texto = "Qual biblioteca do Angular possui um sistema de navegação avançado do lado do cliente e roteamento com base em componentes angulares? Resp: (1)Angular HttpClient  (2)Angular Forms  (3)Angular Animations  (4)Angular PWA  (5)Angular Route"
                        },
                        new
                        {
                            id = 2,
                            liberada = true,
                            resposta = "4",
                            texto = "É um bloco de códigos HTML que informa como renderizar o componente podendo ser referenciado um arquivo externo ou diretamente no componente Resp: (1)component  (2)css  (3)module  (4)template  (5)selector"
                        },
                        new
                        {
                            id = 3,
                            liberada = true,
                            resposta = "4",
                            texto = "Qual é o comando do Angular CLI que gera ou modifica arquivos com base em um esquema? Resp: (1)ng serve  (2)ng e2e  (3)ng e2e  (4)ng generate  (5)ng build"
                        },
                        new
                        {
                            id = 4,
                            liberada = true,
                            resposta = "2",
                            texto = "É usado para identificarmos um componente. Para todo o componente existe um elemento únicoassociado que permite que ele seja adicionado em um documento HTML.A quem o texto faz referência? Resp:  (1)component  (2)selector  (3)template  (4)module  (5)css"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}