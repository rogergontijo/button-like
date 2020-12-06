using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RockContentChallenge.Infra.Migrations
{
    public partial class InitialCreate : Migration
    {
        private readonly string SQL_INITIAL_CREATE_AUTHOR = @$"
            INSERT INTO Author
            VALUES ('{new Guid("d2c469fc-515b-4161-bffd-ab91beed76e2")}', 'Roger Gontijo Resende', '{DateTime.Now}')";

        private readonly string SQL_INITIAL_CREATE_ARTICLE = @$"
            INSERT INTO Article
            VALUES (NEWID(), 'Oportunidade Rock Content', 'Vaga .NET Developer + oportunidade de obter fluência em inglês.', '{new Guid("d2c469fc-515b-4161-bffd-ab91beed76e2")}', 0, '{DateTime.Now}')";

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Text = table.Column<string>(type: "varchar(max)", nullable: false),
                    AuthorGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AmountLike = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Article_Author_AuthorGuid",
                        column: x => x.AuthorGuid,
                        principalTable: "Author",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_AuthorGuid",
                table: "Article",
                column: "AuthorGuid");

            migrationBuilder.Sql(SQL_INITIAL_CREATE_AUTHOR);
            migrationBuilder.Sql(SQL_INITIAL_CREATE_ARTICLE);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "Author");
        }
    }
}
