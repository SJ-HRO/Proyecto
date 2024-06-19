using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    // Clase que representa un producto con su nombre, cantidad y precio.
    public class Product
    {
        public string Name { get; set; } // Nombre del producto
        public int Quantity { get; set; } // Cantidad del producto
        public double Price { get; set; } // Precio del producto
    }
}
