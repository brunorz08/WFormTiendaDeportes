using StockCasaDeDeportes.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockCasaDeDeportes
{
    public partial class FormBorrar : Form
    {
        TiendaCOntext _dbContext;
        public FormBorrar()
        {
            InitializeComponent();
            _dbContext = TiendaContextManager.GetDbContext();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            string id = txtid.Text.Trim();
            var productoId = int.Parse(id);

            var producto = _dbContext.Productos.Find(productoId);
            if (producto != null)
            {
                _dbContext.Productos.Remove(producto);
                _dbContext.SaveChanges();
                MessageBox.Show("Borrado exitoso","Ok",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
