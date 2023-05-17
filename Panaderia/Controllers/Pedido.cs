using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Panaderia.Data;
using Panaderia.Models;
using System.Data;

namespace Panaderia.Controllers
{
    [ApiController]
    [Route("PEDIDOS")]
    public class Pedido : ControllerBase
    {
        [HttpGet]
        [Route("Listar")]
        public dynamic ListarPedido()
        {

            DataTable Pedido = Conexion.Listar("spOBTENER_Pedido");

            string jsaonPedido = JsonConvert.SerializeObject(Pedido);

            return new
            {
                success = true,
                mesage = "exito",
                result = new
                {

                    Pedido = JsonConvert.DeserializeObject<List<Pedidos>>(jsaonPedido),
                }
            };
        }
    }
}
