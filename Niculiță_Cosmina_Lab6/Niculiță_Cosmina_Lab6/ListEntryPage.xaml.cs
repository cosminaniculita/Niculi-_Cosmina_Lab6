using Niculiță_Cosmina_Lab6.Models;
using Niculiță_Cosmina_Lab6.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using ListView = Xamarin.Forms.PlatformConfiguration.AndroidSpecific.ListView;

namespace Niculiță_Cosmina_Lab6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListEntryPage : ContentPage
    { 
        protected override async void OnAppearing()
        {
          
            base.OnAppearing();
            listView<Cell>.ItemsSource = await App.Database.GetShopListsAsync();
        }
        async void OnShopListAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListEntryPage
            {
                BindingContext = new ShopList()
            });
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ListEntryPage
                {
                    BindingContext = e.SelectedItem as ShopList
                });
            }
        }
        async void OnChooseButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductPage((ShopList)
           this.BindingContext)
            {
                BindingContext = new Product()
            });

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var shopl = (ShopList)BindingContext;

            ListView.ItemsSource = await App.Database.GetListProductsAsync(shopl.ID);
        }

        private class ProductPage : Page
        {
            public ProductPage(ShopList bindingContext)
            {
                BindingContext = bindingContext;
            }

            public Product BindingContext { get; set; }
        }
    }
 }
     