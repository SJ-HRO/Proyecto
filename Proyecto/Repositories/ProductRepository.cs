using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Models;

namespace Proyecto.Repositories
{
    // Repositorio estático para gestionar la lista de productos
    public static class ProductRepository
    {
        // Lista privada para almacenar los productos
        private static List<Models.Product> products = new List<Models.Product>();

        // Método para agregar un producto a la lista
        public static void AddProduct(Models.Product product)
        {
            products.Add(product);
        }

        // Método para obtener todos los productos de la lista
        public static List<Models.Product> GetProducts()
        {
            return new List<Models.Product>(products);
        }
    }
}
