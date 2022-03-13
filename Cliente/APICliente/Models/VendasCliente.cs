using Microsoft.EntityFrameworkCore;


namespace APICliente.Models
{
    public class VendasCliente
    {
        public int Id { get; set; }
        public int CodigoDoCliente { get; set; }
        public string DataDaVenda { get; set; }
        public double Valor { get; set; }
    }
}
