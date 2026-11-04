namespace UD1_EJEMPLO_MOVIES
{
    partial class Movies
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMovie = new System.Windows.Forms.TextBox();
            this.BtnAddMovie = new System.Windows.Forms.Button();
            this.CbAddMovie = new System.Windows.Forms.ComboBox();
            this.LbMovie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(115, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado peliculas de los 80";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(201, 209);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(141, 23);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Cerrar Aplicación";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Peliculas:";
            // 
            // TxtMovie
            // 
            this.TxtMovie.Location = new System.Drawing.Point(361, 117);
            this.TxtMovie.Name = "TxtMovie";
            this.TxtMovie.Size = new System.Drawing.Size(206, 22);
            this.TxtMovie.TabIndex = 3;
            // 
            // BtnAddMovie
            // 
            this.BtnAddMovie.Location = new System.Drawing.Point(201, 159);
            this.BtnAddMovie.Name = "BtnAddMovie";
            this.BtnAddMovie.Size = new System.Drawing.Size(141, 23);
            this.BtnAddMovie.TabIndex = 4;
            this.BtnAddMovie.Text = "Añadir Pelicula";
            this.BtnAddMovie.UseVisualStyleBackColor = true;
            this.BtnAddMovie.Click += new System.EventHandler(this.BtnAddMovie_Click);
            // 
            // CbAddMovie
            // 
            this.CbAddMovie.FormattingEnabled = true;
            this.CbAddMovie.Location = new System.Drawing.Point(361, 158);
            this.CbAddMovie.Name = "CbAddMovie";
            this.CbAddMovie.Size = new System.Drawing.Size(206, 24);
            this.CbAddMovie.TabIndex = 5;
            this.CbAddMovie.SelectedIndexChanged += new System.EventHandler(this.CbAddMovie_SelectedIndexChanged);
            // 
            // LbMovie
            // 
            this.LbMovie.AutoSize = true;
            this.LbMovie.ForeColor = System.Drawing.Color.Red;
            this.LbMovie.Location = new System.Drawing.Point(387, 216);
            this.LbMovie.Name = "LbMovie";
            this.LbMovie.Size = new System.Drawing.Size(44, 16);
            this.LbMovie.TabIndex = 6;
            this.LbMovie.Text = "label3";
            this.LbMovie.Visible = false;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 253);
            this.Controls.Add(this.LbMovie);
            this.Controls.Add(this.CbAddMovie);
            this.Controls.Add(this.BtnAddMovie);
            this.Controls.Add(this.TxtMovie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.label1);
            this.Name = "Quiz";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMovie;
        private System.Windows.Forms.Button BtnAddMovie;
        private System.Windows.Forms.ComboBox CbAddMovie;
        private System.Windows.Forms.Label LbMovie;
    }
}

