using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OOPLab.Models;

namespace OOPLab.Models
{
    public class ATMContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;database=ATMDB;user=root;password=;",
                new MySqlServerVersion(new Version(8, 0, 36))
            );
        }
    }
}