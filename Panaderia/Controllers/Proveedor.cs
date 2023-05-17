using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Panaderia.Data;
using Panaderia.Models;
using System.Data;

namespace Panaderia.Controllers
{
        [ApiController]
        [Route("PROVEEDOR")]
        public class Proveedor : ControllerBase
        {
            [HttpGet]
            [Route("Listar")]
            public dynamic ListarProveedores()
            {
               
                DataTable Proveedor = Conexion.Listar("spOBTENER_PROVEEDOR");            

                string jsaonProveedor = JsonConvert.SerializeObject(Proveedor);

                return new
                {
                    success = true,
                    mesage = "exito",
                    result = new
                    {
                       
                        proveedor = JsonConvert.DeserializeObject<List<Proveedores>>(jsaonProveedor),
                    }
                };
            }
        }
    
}
