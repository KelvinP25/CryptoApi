using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoApi.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conis",
                columns: table => new
                {
                    MonedaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    Valor = table.Column<double>(type: "REAL", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conis", x => x.MonedaId);
                });

            migrationBuilder.InsertData(
                table: "Conis",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 1, "Bitcoin", "https://cdn.icon-icons.com/icons2/1386/PNG/512/btc-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95688.png", 20000.0 });

            migrationBuilder.InsertData(
                table: "Conis",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 2, "Ethereum", "https://cdn.icon-icons.com/icons2/1386/PNG/512/eth-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95753.png", 1226.0 });

            migrationBuilder.InsertData(
                table: "Conis",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 3, "Litecoin", "https://cdn.icon-icons.com/icons2/1386/PNG/512/ltc-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95811.png", 56.509999999999998 });

            migrationBuilder.InsertData(
                table: "Conis",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 4, "TRON", "https://cdn.icon-icons.com/icons2/1386/PNG/512/trx-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95619.png", 0.067979999999999999 });

            migrationBuilder.InsertData(
                table: "Conis",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 5, "Tether", "https://cdn.icon-icons.com/icons2/1386/PNG/512/usdt-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95769.png", 1.0 });

            migrationBuilder.InsertData(
                table: "Conis",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 6, "BNB", "https://cdn.icon-icons.com/icons2/1385/PNG/512/bnb-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95544.png", 240.30000000000001 });

            migrationBuilder.InsertData(
                table: "Conis",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 7, "THETA", "https://cdn.icon-icons.com/icons2/1385/PNG/512/theta-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95494.png", 1.3700000000000001 });

            migrationBuilder.InsertData(
                table: "Conis",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 8, "Degecoin", "https://cdn.icon-icons.com/icons2/1385/PNG/512/doge-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95483.png", 0.072099999999999997 });

            migrationBuilder.InsertData(
                table: "Conis",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 9, "Cardano", "https://cdn.icon-icons.com/icons2/1385/PNG/512/ada-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95297.png", 0.5 });

            migrationBuilder.InsertData(
                table: "Conis",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 10, "Solana", "https://cdn.jsdelivr.net/gh/atomiclabs/cryptocurrency-icons@bea1a9722a8c63169dcc06e86182bf2c55a76bbc/128/black/sol.png", 39.490000000000002 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conis");
        }
    }
}
