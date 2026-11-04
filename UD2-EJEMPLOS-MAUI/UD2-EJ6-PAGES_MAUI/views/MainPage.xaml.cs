namespace UD2_EJ6_PAGES_MAUI
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void IBtnTire_Clicked(object sender, EventArgs e)
        {
            //navegamos hacia la pagina de los neumaticos
            await Shell.Current.GoToAsync(nameof(views.TirePage));
        }

        private async void IBtnDate_Clicked(object sender, EventArgs e)
        {
            //navegamos hacia la pagina de las citas
            await Shell.Current.GoToAsync(nameof(views.DatePage));
        }

        private async void IBtnContact_Clicked(object sender, EventArgs e)
        {
            //navegamos hacia la pagina de los contactos
            await Shell.Current.GoToAsync(nameof(views.ContactPage));
        }
    }
}
