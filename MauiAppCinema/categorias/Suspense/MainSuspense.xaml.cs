namespace MauiAppCinema.categorias.Suspense;

public partial class MainSuspense : ContentPage
{
	public MainSuspense()
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

    private void filme1s_Clicked(object sender, EventArgs e)
    {

    }

    private void filme2s_Clicked(object sender, EventArgs e)
    {

    }

    private void filme3s_Clicked(object sender, EventArgs e)
    {

    }

    private void filme4s_Clicked(object sender, EventArgs e)
    {

    }
}