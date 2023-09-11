using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_SuperStart_Interfaz.Interfaz
{
    internal class Heroe
    {
        protected string identidadSecreta, nombreDeHeroe;

        public string ObtenerIdentidad()
        {
            return identidadSecreta;
        }

        public string ObtenerNombre()
        {
            return nombreDeHeroe;
        }
    }
}
