using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizAngular.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Perguntas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    texto = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    resposta = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    liberada = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perguntas", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Perguntas",
                columns: new[] { "id", "liberada", "resposta", "texto" },
                values: new object[,]
                {
                    { 1, true, "5", "Qual biblioteca do Angular possui um sistema de navegação avançado do lado do cliente e roteamento com base em componentes angulares? Resp: (1)Angular HttpClient  (2)Angular Forms  (3)Angular Animations  (4)Angular PWA  (5)Angular Route" },
                    { 2, true, "4", "É um bloco de códigos HTML que informa como renderizar o componente podendo ser referenciado um arquivo externo ou diretamente no componente Resp: (1)component  (2)css  (3)module  (4)template  (5)selector" },
                    { 3, true, "4", "Qual é o comando do Angular CLI que gera ou modifica arquivos com base em um esquema? Resp: (1)ng serve  (2)ng e2e  (3)ng e2e  (4)ng generate  (5)ng build" },
                    { 4, true, "2", "É usado para identificarmos um componente. Para todo o componente existe um elemento únicoassociado que permite que ele seja adicionado em um documento HTML.A quem o texto faz referência? Resp:  (1)component  (2)selector  (3)template  (4)module  (5)css" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Perguntas");
        }
    }
}
