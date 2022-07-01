using Microsoft.EntityFrameworkCore;

public class Contexto: DbContext
{
    public DbSet<Coins> Conis { get; set; }

    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Coins>().HasData(
            new Coins(){
                MonedaId = 1,
                Descripcion = "Bitcoin",
                Valor = 20000,
                ImageUrl = "https://cdn.icon-icons.com/icons2/1386/PNG/512/btc-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95688.png"
            },
            new Coins(){
                MonedaId = 2,
                Descripcion = "Ethereum",
                Valor = 1226,
                ImageUrl = "https://cdn.icon-icons.com/icons2/1386/PNG/512/eth-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95753.png"
            },
            new Coins(){
                MonedaId = 3,
                Descripcion = "Litecoin",
                Valor = 56.51,
                ImageUrl = "https://cdn.icon-icons.com/icons2/1386/PNG/512/ltc-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95811.png"
            },
            new Coins(){
                MonedaId = 4,
                Descripcion = "TRON",
                Valor = 0.067980,
                ImageUrl = "https://cdn.icon-icons.com/icons2/1386/PNG/512/trx-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95619.png"
            },
            new Coins(){
                MonedaId = 5,
                Descripcion = "Tether",
                Valor = 1.00,
                ImageUrl = "https://cdn.icon-icons.com/icons2/1386/PNG/512/usdt-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95769.png"
            },
            new Coins(){
                MonedaId = 6,
                Descripcion = "BNB",
                Valor = 240.30,
                ImageUrl = "https://cdn.icon-icons.com/icons2/1385/PNG/512/bnb-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95544.png"
            },
            new Coins(){
                MonedaId = 7,
                Descripcion = "THETA",
                Valor = 1.37,
                ImageUrl = "https://cdn.icon-icons.com/icons2/1385/PNG/512/theta-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95494.png"
            },
            new Coins(){
                MonedaId = 8,
                Descripcion = "Degecoin",
                Valor = 0.0721,
                ImageUrl = "https://cdn.icon-icons.com/icons2/1385/PNG/512/doge-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95483.png"
            },
            new Coins(){
                MonedaId = 9,
                Descripcion = "Cardano",
                Valor = 0.50,
                ImageUrl = "https://cdn.icon-icons.com/icons2/1385/PNG/512/ada-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95297.png"
            },
            new Coins(){
                MonedaId = 10,
                Descripcion = "Solana",
                Valor = 39.49,
                ImageUrl = "https://cdn.jsdelivr.net/gh/atomiclabs/cryptocurrency-icons@bea1a9722a8c63169dcc06e86182bf2c55a76bbc/128/black/sol.png"
            }
        );
    }
}