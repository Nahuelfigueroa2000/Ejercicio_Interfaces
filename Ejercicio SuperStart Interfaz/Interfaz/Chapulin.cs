using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_SuperStart_Interfaz.Interfaz
{
    internal class Chapulin : Heroe, IVeloz
    {
        public Chapulin(string nombreReal)
        {
            identidadSecreta = nombreReal;
            nombreDeHeroe = "Chapulin";
        }

        public void Velocidad()
        {
            Console.WriteLine($"{nombreDeHeroe} corre velozmente.");
        }
    }
}
