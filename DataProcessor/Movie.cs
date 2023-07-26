using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor
{
    // 1-. Copiamos el JSON
    // 2-. Editar > Pegado especial > Pegar JSON como clases
    public class Movie
    {
        public string Name { get; set; }
        public string ReleaseDate { get; set; }
        public string[] Genres { get; set; }
    }
}
