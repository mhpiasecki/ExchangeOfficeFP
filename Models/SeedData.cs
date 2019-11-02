using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ExchangeOfficeFP.Repository;
using System;
using System.Linq;
using ExchangeOfficeFP.Models;

namespace ExchangeOffice.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new ExchangeOfficeDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ExchangeOfficeDbContext>>());

            //if (context.Currencies.Any())
            //{
            //    return;   // DB has been seeded
            //}

            context.Currencies.AddRange(
                new Currency
                {
                    CurrencyName = "USD",
                    Amount = 1000,
                    Price = 3.81M,
                    Unit = 1,

                },

                new Currency
                {
                    CurrencyName = "EUR",
                    Amount = 1000,
                    Price = 4.26M,
                    Unit = 1,
                },

                new Currency
                {
                    CurrencyName = "CHF",
                    Amount = 1000,
                    Price = 3.87M,
                    Unit = 1,
                },

                new Currency
                {
                    CurrencyName = "RUB",
                    Amount = 1000,
                    Price = 0.06M,
                    Unit = 1
                },
                new Currency
                {
                    CurrencyName = "CZK",
                    Amount = 100000,
                    Price = 16.71M,
                    Unit = 100
                },
                new Currency
                {
                    CurrencyName = "GBP",
                    Amount = 1000,
                    Price = 4.94M,
                    Unit = 1,
                },
                new Currency
                {
                    CurrencyName = "PLN",
                    Amount = 1000,
                    Price = 1M,
                    Unit = 1
                }
            ); ;
            context.SaveChanges();
        }
    }
}