using Microsoft.EntityFrameworkCore.Migrations;

namespace kindergardennetcore.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminNo);
                });

            migrationBuilder.CreateTable(
                name: "Derses",
                columns: table => new
                {
                    DersNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DersSaati = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DersGunu = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DersKonu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Derses", x => x.DersNo);
                });

            migrationBuilder.CreateTable(
                name: "Ogrencis",
                columns: table => new
                {
                    OgrenciNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OgrenciYas = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    OgrenciSinif = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencis", x => x.OgrenciNo);
                });

            migrationBuilder.CreateTable(
                name: "Ogretmens",
                columns: table => new
                {
                    OgretmenNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgretmenAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OgretmenSinifi = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    OgretmenYasi = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    OgretmenMaas = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogretmens", x => x.OgretmenNo);
                });

            migrationBuilder.CreateTable(
                name: "Okuls",
                columns: table => new
                {
                    OkulNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciSayisi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OgretmenSayisi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SubeSayisi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Okuls", x => x.OkulNo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Derses");

            migrationBuilder.DropTable(
                name: "Ogrencis");

            migrationBuilder.DropTable(
                name: "Ogretmens");

            migrationBuilder.DropTable(
                name: "Okuls");
        }
    }
}
