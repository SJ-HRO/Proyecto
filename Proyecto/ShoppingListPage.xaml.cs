using Microsoft.Maui.Controls;
using Proyecto.Repositories;

namespace Proyecto
{
    public partial class ShoppingListPage : ContentPage
    {
        public ShoppingListPage()
        {
            InitializeComponent();
            // Asignar la lista de productos al ListView al cargar la p�gina
            productListView.ItemsSource = ProductRepository.GetProducts();
        }
    }
}
