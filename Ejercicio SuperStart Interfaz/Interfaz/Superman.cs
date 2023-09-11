using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_SuperStart_Interfaz.Interfaz
{
    internal class Superman : Heroe, IVolador, IVeloz, IFuerza
    {
        public Superman(string nombreReal) { 
            identidadSecreta = nombreReal;
            nombreDeHeroe = "Superman";
        }

        public void Velocidad()
        {
            Console.WriteLine($"{nombreDeHeroe} corre velozmente.");
        }

        public void SuperFuerza()
        {
            Console.WriteLine($"{nombreDeHeroe} usa su fuerza.");
        }

        public void volar()
        {
            Console.WriteLine($"{nombreDeHeroe} esta volando");
        }
    }
}
