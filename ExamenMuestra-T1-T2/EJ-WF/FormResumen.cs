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
    public partial class FormResumen : Form
    {
        public FormResumen(List<string> resumen)
        {
            InitializeComponent();
            label1.Text = string.Join("\n" + resumen);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
