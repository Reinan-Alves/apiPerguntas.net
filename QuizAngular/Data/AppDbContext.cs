using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAngular.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Pergunta> Perguntas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pergunta>()
                .HasData(

                new Pergunta
                {
                    id = 1,
                    texto = "Qual biblioteca do Angular possui um sistema de navegação avançado do lado do cliente e roteamento com base em componentes angulares? Resp: (1)Angular HttpClient  (2)Angular Forms  (3)Angular Animations  (4)Angular PWA  (5)Angular Route",
                    resposta = "5",
                    liberada = true
                },
                new Pergunta
                {
                    id = 2,
                    texto = "É um bloco de códigos HTML que informa como renderizar o componente podendo ser referenciado um arquivo externo ou diretamente no componente Resp: (1)component  (2)css  (3)module  (4)template  (5)selector",
                    resposta = "4",
                    liberada = true
                },
                new Pergunta
                {
                    id = 3,
                    texto = "Qual é o comando do Angular CLI que gera ou modifica arquivos com base em um esquema? Resp: (1)ng serve  (2)ng e2e  (3)ng e2e  (4)ng generate  (5)ng build",
                    resposta = "4",
                    liberada = true
                }, new Pergunta
                {
                    id = 4,
                    texto = "É usado para identificarmos um componente. Para todo o componente existe um elemento únicoassociado que permite que ele seja adicionado em um documento HTML.A quem o texto faz referência? Resp:  (1)component  (2)selector  (3)template  (4)module  (5)css",
                    resposta = "2",
                    liberada = true
                }

                );
        }



    }
}
