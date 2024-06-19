using Microsoft.Maui.Controls;
using Proyecto.Repositories;
using System.Linq;

namespace Proyecto
{
    public partial class SummaryPage : ContentPage
    {
        public SummaryPage()
        {
            InitializeComponent();
            // Calcular el total gastado al cargar la página
            double totalSpent = ProductRepository.GetProducts().Sum(p => p.Quantity * p.Price);
            // Formatear el total gastado para que se muestren dos decimales
            totalSpentLabel.Text = $"Total Gastado: {totalSpent:F2}"; // F2 formatea el número con 2 decimales
        }
    }
}
