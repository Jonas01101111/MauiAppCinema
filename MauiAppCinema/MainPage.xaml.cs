namespace MauiAppCinema
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void aventura_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.Aventura.MainAventura());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }


        }

        private void comedia_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.Comedia.MainComedia());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void drama_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.Drama.MainDrama());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void terror_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.Terror.MainTerror());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void ficcao_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.Ficcao.MainFiccao());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void suspense_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.Suspense.MainSuspense());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void infantil_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.Infantil.MainInfantil());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void animacao_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.Animacao.MainAnimacao());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void documentario_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.Documentario.MainDocumentario());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void guerra_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.Guerra.MainGuerra());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void nacional_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.Nacional.MainNacional());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void romance_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.Romance.MainRomance());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}
