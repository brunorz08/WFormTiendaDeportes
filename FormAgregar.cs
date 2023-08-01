using StockCasaDeDeportes.Context;
using StockCasaDeDeportes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StockCasaDeDeportes
{
    public partial class FormAgregar : Form
    {

        readonly TiendaCOntext _dbContext;

        public FormAgregar()
        {
            InitializeComponent();
            _dbContext = TiendaContextManager.GetDbContext();

        }

         
        
        private void btncargar_Click(object sender, EventArgs e)
        {

            var producto = new Producto()
            {
                Nombre = txtnombre.Text,
                Precio = int.Parse(txtprecio.Text),
                CategoriaId = int.Parse(txtcategoria.Text)
               
            };

            _dbContext.Productos.Add(producto);
            _dbContext.SaveChanges();

            if(producto.Id > 0)
            {
                MessageBox.Show("Proceso exitoso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
