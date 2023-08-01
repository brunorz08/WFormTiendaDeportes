namespace StockCasaDeDeportes
{
    partial class FormAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregar));
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.btncargar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.BackColor = System.Drawing.Color.Transparent;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.Cyan;
            this.lblnombre.Location = new System.Drawing.Point(92, 93);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(100, 23);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre";
            this.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblprecio
            // 
            this.lblprecio.BackColor = System.Drawing.Color.Transparent;
            this.lblprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.ForeColor = System.Drawing.Color.Cyan;
            this.lblprecio.Location = new System.Drawing.Point(81, 152);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(100, 23);
            this.lblprecio.TabIndex = 1;
            this.lblprecio.Text = "Precio";
            this.lblprecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcategoria
            // 
            this.lblcategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoria.ForeColor = System.Drawing.Color.Cyan;
            this.lblcategoria.Location = new System.Drawing.Point(92, 201);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(119, 40);
            this.lblcategoria.TabIndex = 2;
            this.lblcategoria.Text = "Categoria ID";
            this.lblcategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.Black;
            this.txtnombre.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtnombre.Location = new System.Drawing.Point(96, 119);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(143, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.Color.Black;
            this.txtprecio.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtprecio.Location = new System.Drawing.Point(96, 178);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(143, 20);
            this.txtprecio.TabIndex = 4;
            // 
            // txtcategoria
            // 
            this.txtcategoria.BackColor = System.Drawing.Color.Black;
            this.txtcategoria.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtcategoria.Location = new System.Drawing.Point(96, 235);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(143, 20);
            this.txtcategoria.TabIndex = 5;
            // 
            // btncargar
            // 
            this.btncargar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargar.ForeColor = System.Drawing.Color.Cyan;
            this.btncargar.Location = new System.Drawing.Point(96, 294);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(146, 39);
            this.btncargar.TabIndex = 6;
            this.btncargar.Text = "Cargar";
            this.btncargar.UseVisualStyleBackColor = false;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.Cyan;
            this.btnsalir.Location = new System.Drawing.Point(96, 339);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(146, 39);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FormAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(357, 463);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblnombre);
            this.Name = "FormAgregar";
            this.Text = "FormAgregar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.Button btnsalir;
    }
}