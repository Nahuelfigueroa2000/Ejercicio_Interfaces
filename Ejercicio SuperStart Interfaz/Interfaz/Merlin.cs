using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_SuperStart_Interfaz.Interfaz
{
    internal class Merlin : Heroe, IInvisibilidad,IMagico
    {
        public Merlin(string nombreReal) { 
            identidadSecreta = nombreReal;
            nombreDeHeroe = "Merlin";
        }

        public void SerInvisible()
        {
            Console.WriteLine($"{nombreDeHeroe} Se hizo invisible.");
        }

        public void Magia()
        {
            Console.WriteLine($"{nombreDeHeroe} Uso magia.");
        }
    }
}
