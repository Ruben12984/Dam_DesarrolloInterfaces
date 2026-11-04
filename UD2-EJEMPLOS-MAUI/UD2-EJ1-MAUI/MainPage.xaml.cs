namespace UD2_EJ1_MAUI
{
    public partial class MainPage : ContentPage
    {
      
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnSend_Clicked(object sender, EventArgs e)
        {
           await DisplayAlertAsync("Entrada", "has entrado en el sistema tio", "Aceptar");
        }
    }
}
