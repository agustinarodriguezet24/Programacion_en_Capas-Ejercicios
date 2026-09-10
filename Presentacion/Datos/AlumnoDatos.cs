using System.Collections.Generic;

namespace Datos
{
    public class AlumnoDatos
    {
        private List<(int Legajo, string Nombre, string Condicion)> alumnos = new()
        {
            (10042, "Juan Perez", "Aprobado"),
            (10043, "Maria Lopez", "Regular"),
            (10044, "Pedro Gomez", "Aprobado")
        };

        public (int Legajo, string Nombre, string Condicion)? BuscarAlumno(int legajo)
        {
            foreach (var a in alumnos)
            {
                if (a.Legajo == legajo)
                {
                    return a;
                }
            }

            return null;
        }
    }
}
