namespace StockCasaDeDeportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btncargar = new System.Windows.Forms.Button();
            this.btncrearcategoria = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridProductos = new System.Windows.Forms.DataGridView();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(54, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "CASA DE DEPORTES";
            // 
            // btncargar
            // 
            this.btncargar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargar.ForeColor = System.Drawing.Color.Cyan;
            this.btncargar.Location = new System.Drawing.Point(77, 81);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(237, 42);
            this.btncargar.TabIndex = 7;
            this.btncargar.Text = "AGREGAR PRODUCTO";
            this.btncargar.UseVisualStyleBackColor = false;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // btncrearcategoria
            // 
            this.btncrearcategoria.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncrearcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrearcategoria.ForeColor = System.Drawing.Color.Cyan;
            this.btncrearcategoria.Location = new System.Drawing.Point(77, 194);
            this.btncrearcategoria.Name = "btncrearcategoria";
            this.btncrearcategoria.Size = new System.Drawing.Size(237, 42);
            this.btncrearcategoria.TabIndex = 8;
            this.btncrearcategoria.Text = "CREAR CATEGORIA";
            this.btncrearcategoria.UseVisualStyleBackColor = false;
            this.btncrearcategoria.Click += new System.EventHandler(this.btncrearcategoria_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(43, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 49);
            this.label2.TabIndex = 9;
            this.label2.Text = "Listado de Productos";
            // 
            // dataGridProductos
            // 
            this.dataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductos.Location = new System.Drawing.Point(12, 325);
            this.dataGridProductos.Name = "dataGridProductos";
            this.dataGridProductos.Size = new System.Drawing.Size(381, 148);
            this.dataGridProductos.TabIndex = 10;
            this.dataGridProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProductos_CellContentClick);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.ForeColor = System.Drawing.Color.Cyan;
            this.btnactualizar.Location = new System.Drawing.Point(77, 291);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(237, 28);
            this.btnactualizar.TabIndex = 11;
            this.btnactualizar.Text = "ACTUALIZAR";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.ForeColor = System.Drawing.Color.Cyan;
            this.btnborrar.Location = new System.Drawing.Point(77, 138);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(237, 42);
            this.btnborrar.TabIndex = 12;
            this.btnborrar.Text = "BORRAR PRODUCTO";
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(408, 502);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.dataGridProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncrearcategoria);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.Button btncrearcategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridProductos;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnborrar;
    }
}

