
using APICuso.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace APICuso.Data
{
    public class LimiteClienteContext : DbContext
    {
        public LimiteClienteContext()
        { 
        }
        public DbSet<LimiteCliente> LimiteClientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BancoLimites;Data Source=PIT-DESKTOP\SQLEXPRESS01");
        }

    }
}
