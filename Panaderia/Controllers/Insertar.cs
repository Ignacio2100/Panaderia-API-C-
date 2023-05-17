using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Panaderia.Data;
using Panaderia.Models;
using System.Data;

namespace Panaderia.Controllers
{
    [ApiController]
    [Route("INSERTAR_PEDIDOS")]
    public class Insertar : ControllerBase
    {
        [HttpPost]
    [Route("InsertPedidos")]
    public dynamic AgregarPedido(Pedidos pedido)
    {

        List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@PedidoID", pedido.PedidoID.ToString()),
                new Parametro("@ProductoID", pedido.ProductoID.ToString()),
                new Parametro("@ProveedorID", pedido.ProveedorID.ToString()),
                new Parametro("@Cantidad", pedido.Cantidad.ToString()),
                new Parametro("@FechaPedido", pedido.FechaPedido),
               

            };
        bool exito = Conexion.Ejecutar("spInsertarPedido", parametros);
            
        return new
        {
            success = exito,
            mesage = exito ? "exito" : "Error al guardar",
            result = ""
        };
    }

}

}
