namespace UD2_EJ5_INOTIFYPROPERTYCHANGED
{
    public partial class MainPage : ContentPage
    {
        private MatchNames matchnames1;

        public MainPage()
        {
            InitializeComponent();
            //CREAR OBJETO DE LA CLASE MatchNames
            matchnames1 = new MatchNames { Name = "Alberto", LastName = "Lamarca" };
            BindingContext = matchnames1;
        }
    }
    
}
