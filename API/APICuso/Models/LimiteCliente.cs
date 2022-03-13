
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace APICuso.Models
{
    
    public class LimiteCliente
    {

       public int Id { get; set; }
       public int CodigoDoCliente { get; set; }

       public string Nome { get; set; }
       public double? Limite { get; set; }
    }
}
