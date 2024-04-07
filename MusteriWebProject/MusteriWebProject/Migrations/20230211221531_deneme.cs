using Microsoft.EntityFrameworkCore.Migrations;

namespace MusteriWebProject.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins_Information",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminAd = table.Column<string>(type: "Varchar(20)", nullable: true),
                    Sifre = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins_Information", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "Customers_Information",
                columns: table => new
                {
                    CustKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriNo = table.Column<int>(type: "int", nullable: false),
                    Adı = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Soyadı = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Kaynak = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    KayitTarihiBaslangici = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    KayitTarihiBitisi = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Kampanya = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    GorusmeSonucu = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    TelefonNo = table.Column<long>(type: "bigint", nullable: false),
                    AramaTarihi = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Temsilci = table.Column<string>(type: "nvarchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers_Information", x => x.CustKey);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins_Information");

            migrationBuilder.DropTable(
                name: "Customers_Information");
        }
    }
}
