using StockCasaDeDeportes.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCasaDeDeportes
{
    public static class TiendaContextManager
    {
        private static readonly TiendaCOntext _dbContext = new TiendaCOntext();

        public static TiendaCOntext GetDbContext()
        {
            return _dbContext;
        }

    }
}
