namespace pryPerezEtapa5
{
    partial class frmEtapa5
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
            this.btnCrearVehiculo = new System.Windows.Forms.Button();
            this.picVehiculos = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearVehiculo
            // 
            this.btnCrearVehiculo.Location = new System.Drawing.Point(536, 12);
            this.btnCrearVehiculo.Name = "btnCrearVehiculo";
            this.btnCrearVehiculo.Size = new System.Drawing.Size(103, 38);
            this.btnCrearVehiculo.TabIndex = 0;
            this.btnCrearVehiculo.Text = "Crear vehiculo";
            this.btnCrearVehiculo.UseVisualStyleBackColor = true;
            this.btnCrearVehiculo.Click += new System.EventHandler(this.btnCrearVehiculo_Click);
            // 
            // picVehiculos
            // 
            this.picVehiculos.Location = new System.Drawing.Point(12, 12);
            this.picVehiculos.Name = "picVehiculos";
            this.picVehiculos.Size = new System.Drawing.Size(518, 283);
            this.picVehiculos.TabIndex = 1;
            this.picVehiculos.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(536, 75);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 38);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmEtapa5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 307);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.picVehiculos);
            this.Controls.Add(this.btnCrearVehiculo);
            this.Name = "frmEtapa5";
            this.Text = "Etapa 5 - CREAR OBJETOS POR CÓDIGO - ALEATORIO";
            ((System.ComponentModel.ISupportInitialize)(this.picVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearVehiculo;
        private System.Windows.Forms.PictureBox picVehiculos;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

