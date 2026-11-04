using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ_WF
{
    public partial class Form1 : Form
    {
        private const decimal PRECIO_5K = 8;
        private const decimal PRECIO_10K = 12;
        private const decimal PRECIO_MEDIAMETA = 18;
        private const decimal SOCIO = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private decimal Calcular_Precio()
        {
            decimal precio = 0;
            if (Rb5KM.Checked)
            {
                precio = PRECIO_5K;
            }
            if (Rb10KM.Checked)
            {
                precio = PRECIO_10K;
            }
            if (RbMeta.Checked)
            {
                precio = PRECIO_MEDIAMETA;
            }

            //comprobamos si es socio
            if(ChkSocio.Checked)
            {
                precio -= SOCIO;
            }

            return precio;
        }

        private bool ValidacionDatos()
        {
            // Comprobar validacion de datos
            if (TxtNombre.Text == "")
            {
                MessageBox.Show("Debes introducir un nombre", "Error!!");
                return false;
            }
            if (CbTalla.SelectedIndex == -1)
            {
                MessageBox.Show("Debes introducir una talla de camiseta", "Error!!");
                return false;
            }

            return true;
        }

        private String DistanciaElegida() 
        {
            if (Rb5KM.Checked)
            {
                return "5 km";
            }
            if (Rb10KM.Checked)
            {
                return "10 km";
            }
            if (RbMeta.Checked)
            {
                return "Media maraton";
            }

            return "";
        }

        private List<String> ObtenerResumen()
        {
            return new List<String>() 
            {
                "CORREDOR: " + TxtNombre.Text.Trim(),
                "EDAD: " + NumEdad.Value.ToString(),
                "Distancia: " + DistanciaElegida(),
                "Talla de Camiseta: " + CbTalla.SelectedText.Trim(),
                "Socio: " + (ChkSocio.Checked ? "Si" : "No"),
                "Precio: " + Calcular_Precio(),
            };
        }

        private void BtnResumen_Click(object sender, EventArgs e)
        {
            // Comprobar validacion de datos
            if (!ValidacionDatos()) return;

            // MessageBox.Show(string.Join(Environment.NewLine, ObtenerResumen()), "Resumen de la carrera");
            using (Form resumen = new FormResumen(ObtenerResumen()))
            {
                resumen.ShowDialog();
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Comprobar validacion de datos
            if (!ValidacionDatos()) return;
        }
    }
}
