using UD2_PIZZA.Views;

namespace UD2_PIZZA
{
    public partial class AppShell : Shell
    {
        
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(PersonalizarPizza), typeof(PersonalizarPizza));
            Routing.RegisterRoute(nameof(ConfirmarPedido), typeof(ConfirmarPedido));
        }
    }
}
