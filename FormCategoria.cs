using StockCasaDeDeportes.Context;
using StockCasaDeDeportes.Models;
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
    public partial class FormCategoria : Form
    {
        private TiendaCOntext _dbContext;
        public FormCategoria()
        {
            _dbContext = TiendaContextManager.GetDbContext();
            InitializeComponent();
        }

        private void btncrearcat_Click(object sender, EventArgs e)
        {
            var categoria = new Categoria
            {
                Nombre = txtnombrecategoria.Text
            };

            _dbContext.Categorias.Add(categoria);
            _dbContext.SaveChanges();


            if (categoria.Id > 0)
            {
                MessageBox.Show("Proceso exitoso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
