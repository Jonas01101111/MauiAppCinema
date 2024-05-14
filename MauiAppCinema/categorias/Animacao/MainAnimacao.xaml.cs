namespace MauiAppCinema.categorias.Animacao;

public partial class MainAnimacao : ContentPage
{
	public MainAnimacao()
	{
		InitializeComponent();
	}

    private void filme4an_Clicked(object sender, EventArgs e)
    {

    }

    private void filme3an_Clicked(object sender, EventArgs e)
    {

    }

    private void filme2an_Clicked(object sender, EventArgs e)
    {

    }

    private void filme1an_Clicked(object sender, EventArgs e)
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