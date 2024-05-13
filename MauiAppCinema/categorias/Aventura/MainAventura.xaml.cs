namespace MauiAppCinema.categorias.Aventura;

public partial class MainAventura : ContentPage
{
	public MainAventura()
	{
		InitializeComponent();
	}

    private void filme1a_Clicked(object sender, EventArgs e)
    {

    }

    private void filme2a_Clicked(object sender, EventArgs e)
    {

    }

    private void filme3a_Clicked(object sender, EventArgs e)
    {

    }

    private void filme4a_Clicked(object sender, EventArgs e)
    {

    }

    private void return_Clicked(object sender, EventArgs e)
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