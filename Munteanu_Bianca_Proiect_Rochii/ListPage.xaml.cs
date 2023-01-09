using Munteanu_Bianca_Proiect_Rochii.Models;

namespace Munteanu_Bianca_Proiect_Rochii;

public partial class ListPage : ContentPage
{
	public ListPage()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (ListaRochii)BindingContext;
        slist.Date = DateTime.UtcNow;
        await App.Database.SaveListaRochiiAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (ListaRochii)BindingContext;
        await App.Database.DeleteListaRochiiAsync(slist);
        await Navigation.PopAsync();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        var shopl = (ListaRochii)BindingContext;

        listView.ItemsSource = await App.Database.GetListProductsAsync(shopl.ID);
    }
    async void OnChooseButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProductPage((ListaRochii)
       this.BindingContext)
        {
            BindingContext = new Product()
        });

    }
}