using APICliente.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.IO;
using System.Text;
using System;
using Newtonsoft.Json;
using APICliente.Data;

namespace APICliente.Controllers
{
    public class VendasClienteController : Controller
    {
        [HttpGet("Vender")]
        public ActionResult Vender()
        {
            return View();
        }

        [HttpPost("Vender")]
        public ActionResult Vender(VendasCliente Venda)
        {
            try
            {
                Venda.DataDaVenda = DateTime.Today.ToString();
                WebRequest request = WebRequest.Create($"http://localhost:5010/BuscarLimite/{Venda.CodigoDoCliente}");
                request.Method = "GET";
                request.Timeout = 35000;

                double captaSaldo;
                WebResponse response = request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                {
                    StreamReader leitor = new StreamReader(stream);

                    captaSaldo = JsonConvert.DeserializeObject<double>(leitor.ReadToEnd());

                }
                if (Venda.Valor > captaSaldo)
                {
                    return View("SaldoInsuficiente");
                }
                else
                {
                    //TODO: Cadastrar venda no BD de vendas        
                    using (var contexto = new ClienteContext()) {
                        contexto.VendasClientes.Add(Venda);
                        contexto.SaveChanges();

                    }


                    WebRequest requestDebito = WebRequest.Create($"http://localhost:5010/AlterarCredito/{Venda.CodigoDoCliente}/{Venda.Valor}");
                    request.Method = "GET";
                    request.Timeout = 35000;
                    double valorDebitado;
                    WebResponse responseDebito = requestDebito.GetResponse();
                    using (Stream stream = responseDebito.GetResponseStream())
                    {
                        StreamReader leitor2 = new StreamReader(stream);

                       valorDebitado = JsonConvert.DeserializeObject<double>(leitor2.ReadToEnd());

                    }

                    return Ok("Valor Debitado : " + valorDebitado);

                }
            }
            catch (Exception ex) { return BadRequest(ex.Message); }


        }

        [HttpGet("SaldoInsuficiente")]
        public ActionResult SaldoInsuficiente()
        {
            return View();
        }

   



    }
}
