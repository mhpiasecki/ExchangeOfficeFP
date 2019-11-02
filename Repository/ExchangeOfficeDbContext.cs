using ExchangeOfficeFP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeOfficeFP.Repository
{
    public class ExchangeOfficeDbContext : DbContext
    {
        public DbSet<Currency> Currencies { get; set; }

        public ExchangeOfficeDbContext(DbContextOptions<ExchangeOfficeDbContext> options)
  : base(options)
        {
        }

    }
}
