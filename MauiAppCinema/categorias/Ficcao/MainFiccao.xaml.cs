namespace MauiAppCinema.categorias.Ficcao;

public partial class MainFiccao : ContentPage
{
	public MainFiccao()
	{
		InitializeComponent();
	}

    private void filme1f_Clicked(object sender, EventArgs e)
    {

    }

    private void filme2f_Clicked(object sender, EventArgs e)
    {

    }

    private void filme3f_Clicked(object sender, EventArgs e)
    {

    }

    private void filme4f_Clicked(object sender, EventArgs e)
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