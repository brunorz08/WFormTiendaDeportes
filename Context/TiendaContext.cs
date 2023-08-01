using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StockCasaDeDeportes.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StockCasaDeDeportes.Context
{
    using System.Data.Entity;

    public class TiendaCOntext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        // Puedes agregar más propiedades DbSet para cada una de tus entidades.

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Aquí puedes configurar la configuración de tus entidades si lo deseas.
            // Por ejemplo, establecer relaciones, índices, etc.
            base.OnModelCreating(modelBuilder);
        }
    }


}







