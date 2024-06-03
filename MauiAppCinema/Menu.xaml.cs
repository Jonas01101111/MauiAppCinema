namespace MauiAppCinema;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private void iniciar_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new MainPage());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}