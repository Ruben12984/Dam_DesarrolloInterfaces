using System.Collections.ObjectModel;
using System.ComponentModel;
using UD2_EJ7_CAROUSEL.Models;

namespace UD2_EJ7_CAROUSEL.Views;

public partial class CarouselPage : ContentPage
{
	//vamos a declarar una coleccion para los juguetes
	public ObservableCollection<Toy> ListToys { get; set; } = new ObservableCollection<Toy>
	{
		new Toy () {NameToy="Robot", PriceToy=14, ImageToy="robot.jpg", AgeRecommended=9},
		new Toy () {NameToy="Pelota", PriceToy=10, ImageToy="ball.jpg", AgeRecommended=4},
		new Toy () {NameToy="Muñeca", PriceToy=14, ImageToy="doll.jpg", AgeRecommended=6},
		new Toy () {NameToy="Coche carreras", PriceToy=14, ImageToy="car.jpg", AgeRecommended=5}
	};

	//declaramos el objeto de juguete seleccionado (SelectedToy)

	private Toy? _selectedToy;
	public Toy? SelectedToy { 
		get { return _selectedToy; }
		set { _selectedToy = value;
			OnPropertyChanged();
		}
	}

 	public CarouselPage()
	{
		InitializeComponent();
		//conectamos el carousel con el observable colecction
		BindingContext = this;
	}
}