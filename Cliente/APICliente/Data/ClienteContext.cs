
using APICliente.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICliente.Data
{
    public class ClienteContext : DbContext
    {

        public ClienteContext() 
        { }

        public DbSet<VendasCliente> VendasClientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ClienteDb;Data Source=PIT-DESKTOP\SQLEXPRESS01");
        }

    }
}
