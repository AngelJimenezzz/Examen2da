namespace TiendaDepartamental.Models
{
    public class Producto
    {
        public int Id { get; set; } // Se usará para identificar el producto
        public string Nombre { get; set; } = "";
        public decimal Precio { get; set; }
        public string Departamento { get; set; } = "";
    }
}
