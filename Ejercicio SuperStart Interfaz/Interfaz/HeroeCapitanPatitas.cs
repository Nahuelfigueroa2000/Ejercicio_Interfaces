using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_SuperStart_Interfaz.Interfaz
{
    internal class HeroeCapitanPatitas : Heroe, IVeloz, IFuerza
    {
        public HeroeCapitanPatitas(string nombreReal)
        {
            identidadSecreta = nombreReal;
            nombreDeHeroe = "Capitan Patitas";
        }

        public void Velocidad()
        {
            Console.WriteLine($"{nombreDeHeroe} corre velozmente.");
        }

        public void SuperFuerza()
        {
            Console.WriteLine($"{nombreDeHeroe} usa su fuerza.");
        }
    }
}
