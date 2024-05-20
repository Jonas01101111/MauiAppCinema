namespace MauiAppCinema.categorias.Terror;

public partial class MainTerror : ContentPage
{
	public MainTerror()
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

    private void filme1t_Clicked(object sender, EventArgs e)
    {

    }

    private void filme2t_Clicked(object sender, EventArgs e)
    {

    }

    private void filme3t_Clicked(object sender, EventArgs e)
    {

    }

    private void filme4t_Clicked(object sender, EventArgs e)
    {

    }
}