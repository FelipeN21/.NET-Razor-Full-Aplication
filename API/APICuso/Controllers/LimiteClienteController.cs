using APICuso.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICuso.Controllers
{
    public class LimiteClienteController : Controller
    {

        // GET: LimiteClienteController
        [HttpGet("Help")]
        public ActionResult Help()
        {
            return Ok("Api Para relacionamento Bancario e acoes em conta");
        }

        // GET: LimiteClienteController/Details/5
        [HttpGet("BuscarLimite/{CodigoCliente}")]
        public ActionResult BuscarLimite(int CodigoCliente)
        {
            try
            {
                using (var contexto = new LimiteClienteContext())
                {
                    var busca = contexto.LimiteClientes.Where(B => B.CodigoDoCliente == CodigoCliente).FirstOrDefault();

                    if (busca.Limite == null)
                    {
                        return Ok(0.0);
                    }
                    else
                    {
                        return Json(busca.Limite);
                        //return Ok(busca.Limite);
                    }
                }
            }
            catch (Exception ex) { 
                return BadRequest(ex.Message);
            }


        }

        [HttpGet("AlterarCredito/{CodigoCliente}/{debito}")]
        public ActionResult AlterarCredito(int CodigoCliente, double debito)
        {
            try
            {
                using (var contexto = new LimiteClienteContext())
                {
                    var busca = contexto.LimiteClientes.Where(B => B.CodigoDoCliente == CodigoCliente).FirstOrDefault();

                    if (busca.Limite == null)
                    {
                        busca.Limite = 0;
                    }
                    busca.Limite = busca.Limite - debito;
                    contexto.SaveChanges();
                    return Json(debito);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            
        }


 
   




    }
}
