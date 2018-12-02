namespace CPresentacion
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
            this.TablaArticulos = new System.Windows.Forms.DataGridView();
            this.Guardar = new System.Windows.Forms.Button();
            this.esteNombre = new System.Windows.Forms.TextBox();
            this.esteID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TablaArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaArticulos
            // 
            this.TablaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaArticulos.Location = new System.Drawing.Point(357, 51);
            this.TablaArticulos.Name = "TablaArticulos";
            this.TablaArticulos.RowTemplate.Height = 24;
            this.TablaArticulos.Size = new System.Drawing.Size(447, 483);
            this.TablaArticulos.TabIndex = 0;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(82, 119);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(96, 30);
            this.Guardar.TabIndex = 2;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // esteNombre
            // 
            this.esteNombre.Location = new System.Drawing.Point(82, 79);
            this.esteNombre.Name = "esteNombre";
            this.esteNombre.Size = new System.Drawing.Size(142, 22);
            this.esteNombre.TabIndex = 1;
            // 
            // esteID
            // 
            this.esteID.Location = new System.Drawing.Point(82, 51);
            this.esteID.Name = "esteID";
            this.esteID.Size = new System.Drawing.Size(47, 22);
            this.esteID.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 591);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.esteNombre);
            this.Controls.Add(this.esteID);
            this.Controls.Add(this.TablaArticulos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaArticulos;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox esteNombre;
        private System.Windows.Forms.TextBox esteID;
    }
}

