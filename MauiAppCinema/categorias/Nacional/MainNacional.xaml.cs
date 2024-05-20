namespace MauiAppCinema.categorias.Nacional;

public partial class MainNacional : ContentPage
{
	public MainNacional()
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

    

    private void filme1n_Clicked(object sender, EventArgs e)
    {

    }

    private void filme2n_Clicked(object sender, EventArgs e)
    {

    }

    private void filme3n_Clicked(object sender, EventArgs e)
    {

    }

    private void filme4n_Clicked(object sender, EventArgs e)
    {

    }
}