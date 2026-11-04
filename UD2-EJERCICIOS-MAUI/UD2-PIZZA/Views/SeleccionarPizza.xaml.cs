using UD2_PIZZA.Models;

namespace UD2_PIZZA.Views;

public partial class SeleccionarPizza : ContentPage
{
	public SeleccionarPizza()
	{
		InitializeComponent();
	}

    private async void btnSiguiente_Clicked(object sender, EventArgs e)
    {
		if (pckPizza.SelectedIndex == -1)
		{
			await DisplayAlertAsync("Error", "tienes que seleccionar alguna pizza", "OK");
		} 	
		else
		{
			Pizza.Instancia.Tipo = pckPizza.SelectedItem.ToString();
			Pizza.Instancia.Cantidad = (int)sliCantidad.Value;

            await Shell.Current.GoToAsync(nameof(PersonalizarPizza));
        }
		

		
    }

    private void sliCantidad_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		lblCantidad.Text = $"Cantidad:  {(int)e.NewValue}";
    }
}