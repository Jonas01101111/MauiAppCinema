namespace MauiAppCinema.categorias.Infantil;

public partial class MainInfantil : ContentPage
{
	public MainInfantil()
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

    private void filme1i_Clicked(object sender, EventArgs e)
    {

    }

    private void filme2i_Clicked(object sender, EventArgs e)
    {

    }

    private void filme3i_Clicked(object sender, EventArgs e)
    {

    }

    private void filme4i_Clicked(object sender, EventArgs e)
    {

    }
}