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

namespace StockCasaDeDeportes
{
    public partial class Form1 : Form
    {
        private TiendaCOntext _dbContext;
        private Timer colorTimer;
        private Random random;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
            _dbContext = TiendaContextManager.GetDbContext();

        }

        public void InitializeTimer()
        {
            colorTimer = new Timer();
            colorTimer.Interval = 500;
            colorTimer.Tick += ColorTimer_Tick;

            random = new Random();
            colorTimer.Start();

        }

        private void ColorTimer_Tick(object sender, EventArgs e)
        {
            // Generar un color aleatorio
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            // Asignar el nuevo color al Label
            label1.ForeColor = randomColor;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            FormAgregar form = new FormAgregar();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Producto> listaProductos = _dbContext.Productos.ToList();
            List<Categoria> listaCategorias = _dbContext.Categorias.ToList();
            var resultado = from a in listaProductos
                            join b in listaCategorias on a.CategoriaId equals b.Id
                            select new
                            {
                                Id = a.Id,
                                Nombre = a.Nombre,
                                Precio = a.Precio,
                                Categoria = b.Nombre,
                                IdCategoria = b.Id
                            };

            dataGridProductos.DataSource = resultado.ToList();


        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            FormAgregar form = new FormAgregar();
            form.Show();
        }

        private void btncrearcategoria_Click(object sender, EventArgs e)
        {
            FormCategoria formcat = new FormCategoria();
            formcat.Show();
        }

        private void dataGridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnactualizar_Click(object sender, EventArgs e)
        {

            List<Producto> listaProductos = _dbContext.Productos.ToList();
            List<Categoria> listaCategorias = _dbContext.Categorias.ToList();
            var resultado = from a in listaProductos
                            join b in listaCategorias on a.CategoriaId equals b.Id
                            select new
                            {
                                Id = a.Id,
                                Nombre = a.Nombre,
                                Precio = a.Precio,
                                Categoria = b.Nombre,
                                IdCategoria = b.Id
                            };

            dataGridProductos.DataSource = resultado.ToList();

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            FormBorrar form = new FormBorrar();
            form.Show();
        }
    }
}
