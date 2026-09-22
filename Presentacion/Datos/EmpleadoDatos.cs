using System.Collections.Generic;

namespace Datos
{
    public class EmpleadoDatos
    {
        private List<(int Id, string Nombre, string Puesto, string Departamento)> empleados = new()
        {
            (501, "Ana Torres", "Analista", "Sistemas"),
            (502, "Carlos Ruiz", "Contador", "Administracion"),
            (503, "Lucia Fernandez", "Gerente", "Recursos Humanos")
        };

        public (int Id, string Nombre, string Puesto, string Departamento)? BuscarEmpleado(int id)
        {
            foreach (var e in empleados)
            {
                if (e.Id == id)
                {
                    return e;
                }
            }

            return null;
        }
    }
}
