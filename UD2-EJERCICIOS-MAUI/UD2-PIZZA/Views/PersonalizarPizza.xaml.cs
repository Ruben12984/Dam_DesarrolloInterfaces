using UD2_PIZZA.Models;

namespace UD2_PIZZA.Views;

public partial class PersonalizarPizza : ContentPage
{
	public PersonalizarPizza()
	{
		InitializeComponent();
	}

    private void chkQuesoextra_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        Pizza.Instancia.QuesoExtra = e.Value;
    }

    private void chkJamon_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        Pizza.Instancia.Jamon = e.Value;
    }

    private void chkChampinones_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        Pizza.Instancia.Champinones = e.Value;
    }

    private void chkAceitunas_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        Pizza.Instancia.Aceitunas = e.Value;
    }

    private void chkPimientos_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        Pizza.Instancia.Pimientos = e.Value;
    }

    private async void Btn_volver_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private async void btn_siguiente_clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ConfirmarPedido));
    }
}