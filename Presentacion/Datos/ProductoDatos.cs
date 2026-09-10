using System.Collections.Generic;

namespace Datos
{
    public class ProductoDatos
    {
        
        private List<(string Codigo, string Nombre, double Precio)> productos = new()
        {
            ("PROD-101", "Teclado", 25000),
            ("PROD-102", "Mouse", 15000),
            ("PROD-103", "Monitor", 180000)
        };

        
        public (string Codigo, string Nombre, double Precio)? BuscarProducto(string codigo)
        {
            foreach (var p in productos)
            {
                if (p.Codigo == codigo)
                {
                    return p;
                }
            }

            return null;
        }
    }
}
