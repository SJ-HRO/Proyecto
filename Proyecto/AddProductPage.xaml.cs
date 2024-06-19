using Microsoft.Maui.Controls;
using Proyecto.Models;
using Proyecto.Repositories;
using System;
using System.Globalization;

namespace Proyecto
{
    public partial class AddProductPage : ContentPage
    {
        public AddProductPage()
        {
            InitializeComponent();
        }

        // Método que se ejecuta cuando se presiona el botón de agregar
        private async void OnAddButtonClicked(object sender, EventArgs e)
        {
            // Validación básica para evitar errores de entrada
            if (string.IsNullOrWhiteSpace(productName.Text) ||
                string.IsNullOrWhiteSpace(productQuantity.Text) ||
                string.IsNullOrWhiteSpace(productPrice.Text))
            {
                await DisplayAlert("Error", "Por favor, complete todos los campos", "OK");
                return;
            }

            if (!int.TryParse(productQuantity.Text, out int quantity) ||
                !double.TryParse(productPrice.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double price))
            {
                await DisplayAlert("Error", "Por favor, ingrese una cantidad y un precio válidos", "OK");
                return;
            }

            // Crear un nuevo producto con los datos ingresados por el usuario
            var product = new Product
            {
                Name = productName.Text,
                Quantity = quantity,
                Price = price
            };

            // Agregar el producto al repositorio
            ProductRepository.AddProduct(product);

            // Mostrar un mensaje de confirmación al usuario
            await DisplayAlert("Producto Agregado", "El producto ha sido agregado exitosamente", "OK");

            // Limpiar los campos de entrada
            productName.Text = string.Empty;
            productQuantity.Text = string.Empty;
            productPrice.Text = string.Empty;
        }
    }
}
