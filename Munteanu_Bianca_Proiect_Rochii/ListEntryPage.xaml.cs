using Munteanu_Bianca_Proiect_Rochii.Models;
namespace Munteanu_Bianca_Proiect_Rochii;


public partial class ListEntryPage : ContentPage
{
	public ListEntryPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetListaRochiiAsync();
    }
    async void OnListaRochiiAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListPage
        {
            BindingContext = new ListaRochii()
        });
    }
    async void OnListaRochiiItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ListPage
            {
                BindingContext = e.SelectedItem as ListaRochii
            });
        }
    }
}