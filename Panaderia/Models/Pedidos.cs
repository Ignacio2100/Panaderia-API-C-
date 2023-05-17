namespace Panaderia.Models
{
    public class Pedidos
    {
        public int PedidoID { get; set; }
        public int ProductoID { get; set; }
        public int ProveedorID { get; set; }
        public int Cantidad { get; set; }
        public string FechaPedido { get; set; }

    }
}
