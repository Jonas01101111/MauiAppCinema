namespace MauiAppCinema.categorias.Drama;

public partial class MainDrama : ContentPage
{
	public MainDrama()
	{
		InitializeComponent();
	}

    private void filme1dm_Clicked(object sender, EventArgs e)
    {

    }

    private void filme2dm_Clicked(object sender, EventArgs e)
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

    private void filme3dm_Clicked(object sender, EventArgs e)
    {

    }

    private void filme4dm_Clicked(object sender, EventArgs e)
    {

    }
}