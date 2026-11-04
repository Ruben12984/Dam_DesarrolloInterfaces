using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1_EJEMPLO_MOVIES
{
    public partial class Movies : Form
    {
        public Movies()
        {
            InitializeComponent();
        }

        

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddMovie_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtMovie.Text))
                {
                    CbAddMovie.Items.Add(TxtMovie.Text);
                }
                else
                {
                    MessageBox.Show("Introduce una pelicula", "Advertencia");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}.","Error del sistema");
            }
            
        }

        private void CbAddMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            LbMovie.Text = CbAddMovie.Text;
            LbMovie.Visible = true;
        }
    }
}
