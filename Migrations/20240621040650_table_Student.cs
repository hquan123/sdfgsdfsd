using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace baithi15.Migrations
{
    /// <inheritdoc />
    public partial class table_Student : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cau2",
                columns: table => new
                {
                    IdNhanvien = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Diachi = table.Column<string>(type: "TEXT", nullable: false),
                    Msv = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cau2", x => x.IdNhanvien);
                    table.ForeignKey(
                        name: "FK_Cau2_Cau1_IdNhanvien",
                        column: x => x.IdNhanvien,
                        principalTable: "Cau1",
                        principalColumn: "IdNhanvien",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cau2");
        }
    }
}
