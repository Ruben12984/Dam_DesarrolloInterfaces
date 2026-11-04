namespace UD2_EJ6_PAGES_MAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(views.ContactPage), typeof(views.ContactPage));
        }
    }
}
