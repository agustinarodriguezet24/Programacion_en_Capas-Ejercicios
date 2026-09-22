using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Datos
{
    public class LibroDatos
    {
        private List<(string Isbn, string Titulo, string Autor, bool Disponible)> libros = new()
        {
            ("978-950-07-1234-5", "El Aleph", "Jorge Luis Borges", true),
            ("978-987-566-7890-1", "Rayuela", "Julio Cortazar", false),
            ("978-950-49-4567-8", "Ficciones", "Jorge Luis Borges", true)
        };

        public (string Isbn, string Titulo, string Autor, bool Disponible)? BuscarLibro(string isbn)
        {
            foreach (var l in libros)
            {
                if (l.Isbn == isbn)
                {
                    return l;
                }
            }

            return null;
        }
    }
}