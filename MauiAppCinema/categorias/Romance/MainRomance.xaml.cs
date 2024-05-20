namespace MauiAppCinema.categorias.Romance;

public partial class MainRomance : ContentPage
{
	public MainRomance()
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

    private void filme1r_Clicked(object sender, EventArgs e)
    {

    }

    private void filme2r_Clicked(object sender, EventArgs e)
    {

    }

    private void filme3r_Clicked(object sender, EventArgs e)
    {

    }

    private void filme4r_Clicked(object sender, EventArgs e)
    {

    }
}