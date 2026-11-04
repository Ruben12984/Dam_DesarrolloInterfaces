namespace UD1_EJ3_COLORDIALOG
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.GbPanelColor = new System.Windows.Forms.GroupBox();
            this.btnPanel = new System.Windows.Forms.Button();
            this.btnForm = new System.Windows.Forms.Button();
            this.GbPanelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(169, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "EJEMPLO DE COLOR DIALOGO";
            // 
            // GbPanelColor
            // 
            this.GbPanelColor.Controls.Add(this.btnForm);
            this.GbPanelColor.Controls.Add(this.btnPanel);
            this.GbPanelColor.Location = new System.Drawing.Point(100, 126);
            this.GbPanelColor.Name = "GbPanelColor";
            this.GbPanelColor.Size = new System.Drawing.Size(586, 218);
            this.GbPanelColor.TabIndex = 1;
            this.GbPanelColor.TabStop = false;
            this.GbPanelColor.Text = "Pnael de color";
            // 
            // btnPanel
            // 
            this.btnPanel.Location = new System.Drawing.Point(99, 82);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(161, 96);
            this.btnPanel.TabIndex = 0;
            this.btnPanel.Text = "Color de panel";
            this.btnPanel.UseVisualStyleBackColor = true;
            this.btnPanel.Click += new System.EventHandler(this.btnPanel_Click);
            // 
            // btnForm
            // 
            this.btnForm.Location = new System.Drawing.Point(318, 81);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(164, 97);
            this.btnForm.TabIndex = 1;
            this.btnForm.Text = "Color de la ventana";
            this.btnForm.UseVisualStyleBackColor = true;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GbPanelColor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GbPanelColor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbPanelColor;
        private System.Windows.Forms.Button btnForm;
        private System.Windows.Forms.Button btnPanel;
    }
}

