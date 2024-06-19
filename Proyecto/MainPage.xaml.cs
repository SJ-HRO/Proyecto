using Microsoft.Maui.Controls;
using System;

namespace Proyecto
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAddProductClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddProductPage());
        }

        private async void OnShoppingListClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShoppingListPage());
        }

        private async void OnSummaryClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SummaryPage());
        }
    }
}
