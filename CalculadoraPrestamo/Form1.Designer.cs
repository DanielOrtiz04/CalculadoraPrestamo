namespace CalculadoraPrestamo
{
    partial class Calculadora
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
            this.lblCuotaMensual = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtPlazoMeses = new System.Windows.Forms.TextBox();
            this.txtTasaInteres = new System.Windows.Forms.TextBox();
            this.txtMontoPrestamo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCuotaMensual
            // 
            this.lblCuotaMensual.AutoSize = true;
            this.lblCuotaMensual.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCuotaMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotaMensual.Location = new System.Drawing.Point(313, 285);
            this.lblCuotaMensual.Name = "lblCuotaMensual";
            this.lblCuotaMensual.Size = new System.Drawing.Size(0, 24);
            this.lblCuotaMensual.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(317, 351);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(181, 45);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtPlazoMeses
            // 
            this.txtPlazoMeses.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPlazoMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlazoMeses.Location = new System.Drawing.Point(316, 234);
            this.txtPlazoMeses.Name = "txtPlazoMeses";
            this.txtPlazoMeses.Size = new System.Drawing.Size(181, 29);
            this.txtPlazoMeses.TabIndex = 7;
            this.txtPlazoMeses.Text = "Cuantos Meses?";
            this.txtPlazoMeses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtTasaInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTasaInteres.Location = new System.Drawing.Point(316, 165);
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(181, 29);
            this.txtTasaInteres.TabIndex = 6;
            this.txtTasaInteres.Text = "Interes";
            this.txtTasaInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMontoPrestamo
            // 
            this.txtMontoPrestamo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtMontoPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoPrestamo.Location = new System.Drawing.Point(316, 91);
            this.txtMontoPrestamo.Name = "txtMontoPrestamo";
            this.txtMontoPrestamo.Size = new System.Drawing.Size(181, 29);
            this.txtMontoPrestamo.TabIndex = 5;
            this.txtMontoPrestamo.Text = "Dinero que Desea";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Calculadora de Prestamos";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CalculadoraPrestamo.Properties.Resources.Captura_de_pantalla__120_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCuotaMensual);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPlazoMeses);
            this.Controls.Add(this.txtTasaInteres);
            this.Controls.Add(this.txtMontoPrestamo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Calculadora";
            this.Text = "CalculadoraPrestamos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCuotaMensual;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtPlazoMeses;
        private System.Windows.Forms.TextBox txtTasaInteres;
        private System.Windows.Forms.TextBox txtMontoPrestamo;
        private System.Windows.Forms.Label label1;
    }
}

