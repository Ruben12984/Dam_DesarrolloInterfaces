using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1_EJ4_SAVEDIALOGO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Text files (*.txt)|+.txt|All files(*.*)|*.*";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filename = saveFileDialog1.FileName;

                    //con la ruta vamos a crear un fichero
                    File.WriteAllLines(filename, new[]
                    {
                        "Usuario: " + TbUser.Text,
                        "Contraseña: " + TbPass.Text
                    });
                    MessageBox.Show("Fichero creado en " + filename);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al guardar" + ex.Message);
            }
            
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                TbUser.Font = fontDialog1.Font;
            }
        }
    }
}
