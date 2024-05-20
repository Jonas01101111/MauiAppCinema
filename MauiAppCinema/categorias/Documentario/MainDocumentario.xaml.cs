namespace MauiAppCinema.categorias.Documentario;

public partial class MainDocumentario : ContentPage
{
	public MainDocumentario()
	{
		InitializeComponent();
	}

    private void filme1d_Clicked(object sender, EventArgs e)
    {

    }

    private void filme2d_Clicked(object sender, EventArgs e)
    {

    }

    private void filme3d_Clicked(object sender, EventArgs e)
    {

    }

    private void filme4d_Clicked(object sender, EventArgs e)
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