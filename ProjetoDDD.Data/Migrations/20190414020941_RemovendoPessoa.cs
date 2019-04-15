using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoDDD.Data.Migrations
{
    public partial class RemovendoPessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Materia_MateriaId",
                table: "Pessoa");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Materia_Professor_MateriaId",
                table: "Pessoa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa");

            migrationBuilder.DropIndex(
                name: "IX_Pessoa_Professor_MateriaId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "Ra",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "Professor_MateriaId",
                table: "Pessoa");

            migrationBuilder.RenameTable(
                name: "Pessoa",
                newName: "Professor");

            migrationBuilder.RenameIndex(
                name: "IX_Pessoa_MateriaId",
                table: "Professor",
                newName: "IX_Professor_MateriaId");

            migrationBuilder.AlterColumn<double>(
                name: "Salario",
                table: "Professor",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Professor",
                table: "Professor",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    Ra = table.Column<string>(nullable: true),
                    MateriaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alunos_Materia_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_MateriaId",
                table: "Alunos",
                column: "MateriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Professor_Materia_MateriaId",
                table: "Professor",
                column: "MateriaId",
                principalTable: "Materia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Professor_Materia_MateriaId",
                table: "Professor");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Professor",
                table: "Professor");

            migrationBuilder.RenameTable(
                name: "Professor",
                newName: "Pessoa");

            migrationBuilder.RenameIndex(
                name: "IX_Professor_MateriaId",
                table: "Pessoa",
                newName: "IX_Pessoa_MateriaId");

            migrationBuilder.AlterColumn<double>(
                name: "Salario",
                table: "Pessoa",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AddColumn<string>(
                name: "Ra",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Pessoa",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Professor_MateriaId",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_Professor_MateriaId",
                table: "Pessoa",
                column: "Professor_MateriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Materia_MateriaId",
                table: "Pessoa",
                column: "MateriaId",
                principalTable: "Materia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Materia_Professor_MateriaId",
                table: "Pessoa",
                column: "Professor_MateriaId",
                principalTable: "Materia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
