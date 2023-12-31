﻿using StockCasaDeDeportes.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCasaDeDeportes.Models
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria categoria { get; set; }

       
    }
}
