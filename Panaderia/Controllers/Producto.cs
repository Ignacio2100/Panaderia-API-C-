using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Panaderia.Data;
using Panaderia.Models;
using System.Data;

namespace Panaderia.Controllers
{
    [ApiController]
    [Route("PRODUCTOS")]
    public class Producto :ControllerBase
    {
        [HttpGet]
        [Route("Listar")]
        public dynamic ListarProductos()
        {
            DataTable Productos = Conexion.Listar("spOBTENER_PRODUCTOS");
        

            string jsaonProductos = JsonConvert.SerializeObject(Productos);
            

            return new
            {
                success = true,
                mesage = "exito",
                result = new
                {      
                    productos = JsonConvert.DeserializeObject<List<Productos>>(jsaonProductos),
                    
                }
            };
        }
    }

}
