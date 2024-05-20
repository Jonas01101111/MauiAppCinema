namespace MauiAppCinema.categorias.Guerra;

public partial class MainGuerra : ContentPage
{
	public MainGuerra()
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

    private void filme1g_Clicked(object sender, EventArgs e)
    {

    }

    private void filme2g_Clicked(object sender, EventArgs e)
    {

    }

    private void filme3g_Clicked(object sender, EventArgs e)
    {

    }

    private void filme4g_Clicked(object sender, EventArgs e)
    {

    }
}