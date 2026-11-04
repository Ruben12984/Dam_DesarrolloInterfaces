using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1_EJ6_SECONDFORM
{
    public partial class MainForm : Form
    {
        //declarar variables para los formularios
        private Form student_form, teacher_form, family_form;




        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnNewForm_Click(object sender, EventArgs e)
        {
            if (RbAlumnado.Checked)
            {
                if (student_form == null || student_form.IsDisposed)
                {
                    student_form = new FormStudent();
                    student_form.Show();
                }
                else
                {
                    student_form.BringToFront();
                }

            }
            else if (RbProfesorado.Checked)
            {
                //isDisposes nos indica si la ventana fue cerrada y elminada
                if (teacher_form == null || teacher_form.IsDisposed)
                {
                    using (teacher_form = new NewTeacher())
                    {
                        teacher_form.ShowDialog();
                    }
                    
                }  
            }
            else if (RbFamilias.Checked)
            {
                using (family_form = new UD1_EJ5A_DATABINDING.Form1())
                {
                    family_form.ShowDialog();
                }
            }
        }
    }
}
