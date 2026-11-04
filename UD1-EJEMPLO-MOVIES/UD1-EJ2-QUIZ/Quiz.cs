using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1_EJ2_QUIZ
{
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            //Creamos una variable para guardar toda la información del usuario
            string message_user = "Tu sistema operativo preferido es: ";

            //Comprobamos los radio buttons si estan seleccionados
            message_user += ChexMyRadioButton(RbWindows);
            message_user += ChexMyRadioButton(RbLinux);
            message_user += ChexMyRadioButton(RbMacOS);

            message_user += "Tus especialidades preferidas son: ";

            message_user += CheckMyCheckBoxButton(ChkProgramacion);
            message_user += CheckMyCheckBoxButton(ChkDiseño);
            message_user += CheckMyCheckBoxButton(ChkAdministracionRedes);

            MessageBox.Show(message_user, "informe");

            //metodo para quitar la ultima coma y poner un espacio en blanco
            message_user = message_user.TrimEnd(new char[] { ' ', ',' });

            message_user += " y el numero total de horas son " + NudHours.Value;
        }

        private string CheckMyCheckBoxButton(CheckBox chkbutton)
        {
            if (chkbutton.Checked)
            {
                return chkbutton.Text + " ";
            }
            else
            {
                return " ";
            }
        }

        private string ChexMyRadioButton(RadioButton radiobutton)
        {
            if (radiobutton.Checked) 
            {
                return radiobutton.Text + " ";
            }
            else
            {
                return " ";
            }
            
                    
        }
    }
}
