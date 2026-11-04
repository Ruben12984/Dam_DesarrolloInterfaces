using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1_EJ5A_DATABINDING
{
    public partial class Form1 : Form
    {
        //declarar datos para el enlace del binding
        public string[] myCities = new string[] { "lucena", "Córdoba", "Montilla", "Rute" };
        public List<City> CitiesList;
        public City cityLucena = new City()
        {
            CityName = "Lucena",
            PopulationName = 42999,
            CountryName = "España"
        };



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //establecida la conexion entre el origen de los datos y el combobox
            CbCity.DataSource = myCities;

            // vamos a inicializar la lista de ciudades
            CitiesList = new List<City>()
            {
                new City()
                {
                    CityName = "Sevilla",
                    PopulationName = 700000,
                    CountryName = "España"
                },

                new City()
                {
                    CityName = "Córdoba",
                    PopulationName = 300000,
                    CountryName = "España"
                },

                new City()
                {
                    CityName = "Jaén",
                    PopulationName = 180000,
                    CountryName = "España"
                },

                new City()
                {
                    CityName = "Huelva",
                    PopulationName = 143000,
                    CountryName = "España"
                }
            };
            cityBindingSource.DataSource = CitiesList;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!CitiesList.Contains(cityLucena))
            {
                CitiesList.Add(cityLucena);
                cityBindingSource.DataSource = null;
                cityBindingSource.DataSource = CitiesList;
            }
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (City city in CitiesList.ToList())
                {
                    if (city.CityName == "Sevilla")
                    {
                        CitiesList.Remove(city);
                        cityBindingSource.DataSource = null;
                        cityBindingSource.DataSource = CitiesList;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el borrado " + ex.Message);
            }
            
        }
    }
}
