using Munteanu_Bianca_Proiect_Rochii.Models;

namespace Munteanu_Bianca_Proiect_Rochii;

public partial class ProductPage : ContentPage
{
    ListaRochii sl;
    public ProductPage(ListaRochii slist)
    {
        InitializeComponent();
        sl = slist;
    }
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var product = (Product)BindingContext;
        await App.Database.SaveProductAsync(product);
        listView.ItemsSource = await App.Database.GetProductsAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var product = (Product)BindingContext;
        await App.Database.DeleteProductAsync(product);
        listView.ItemsSource = await App.Database.GetProductsAsync();
    }
    async void OnAddButtonClicked(object sender, EventArgs e)
    {
        Product p;
        if (listView.SelectedItem != null)
        {
            p = listView.SelectedItem as Product;
            var lp = new ListProduct()
            {
                ListaRochiiID = sl.ID,
                ProductID = p.ID
            };
            await App.Database.SaveListProductAsync(lp);
            p.ListProducts = new List<ListProduct> { lp };
            await Navigation.PopAsync();
        }

     /*   async void OnAddButtonClicked(object sender, EventArgs e)
        {
            Product p;
            if (listView.SelectedItem != null)
            {
                p = listView.SelectedItem as Product;
                var lp = new ListProduct()
                {
                    ListaRochiiID = sl.ID,
                    ProductID = p.ID
                };
                await App.Database.SaveListaRochiiAsync(lp);
                p.ListProducts = new List<ListProduct> { lp };
                await Navigation.PopAsync();
            }

        }*/
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetProductsAsync();
    }

   
}