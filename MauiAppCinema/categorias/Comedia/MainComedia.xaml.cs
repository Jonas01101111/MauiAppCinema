namespace MauiAppCinema.categorias.Comedia;

public partial class MainComedia : ContentPage
{
	public MainComedia()
	{
		InitializeComponent();
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

    private void filme1c_Clicked(object sender, EventArgs e)
    {

    }

    private void filme2c_Clicked(object sender, EventArgs e)
    {

    }

    private void filme3c_Clicked(object sender, EventArgs e)
    {

    }

    private void filme4c_Clicked(object sender, EventArgs e)
    {

    }
}