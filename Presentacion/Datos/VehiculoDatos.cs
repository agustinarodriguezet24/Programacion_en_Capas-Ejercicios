using System.Collections.Generic;

namespace Datos
{
    public class VehiculoDatos
    {
        private List<(string Patente, string Modelo, bool TieneDeuda)> vehiculos = new()
        {
            ("AA123CD", "Toyota Corolla", false),
            ("AB456EF", "Ford Focus", true),
            ("AC789GH", "Volkswagen Gol", false)
        };

        public (string Patente, string Modelo, bool TieneDeuda)? BuscarVehiculo(string patente)
        {
            foreach (var v in vehiculos)
            {
                if (v.Patente == patente)
                {
                    return v;
                }
            }

            return null;
        }
    }
}
