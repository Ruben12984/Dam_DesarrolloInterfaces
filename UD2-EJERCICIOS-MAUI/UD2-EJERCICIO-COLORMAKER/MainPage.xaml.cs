namespace UD2_EJERCICIO_COLORMAKER
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            ActualizarColor();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {

            ActualizarColor();
        }

        private void ActualizarColor()
        {
            var red = (int)slred.Value;
            var green = (int)slgreen.Value;
            var blue = (int)slblue.Value;

            colorVSL.BackgroundColor = Color.FromRgb(red, green, blue);
            botonVSL.BackgroundColor = Color.FromRgb(red, green, blue);

            lblcolorVSL.Text = "Hex color: " + red.ToString("X2") + green.ToString("X2") + blue.ToString("x2"); 

        }
    }
}
