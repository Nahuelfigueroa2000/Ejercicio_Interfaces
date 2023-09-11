using Ejercicio_SuperStart_Interfaz.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_SuperStart_Interfaz.interfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos las listas
            List<IVolador> Voladores = new List<IVolador>();
            List<IFuerza> Superfuertes = new List<IFuerza>();
            List<IVeloz> Velozes = new List<IVeloz>();
            List<IMagico> Magicos = new List<IMagico>();
            List<IInvisibilidad> Invisibles = new List<IInvisibilidad>();
            List<Heroe> todosLosHeroes = new List<Heroe>();

            //instanciamos heroes y los ponemos en las listas
            HeroeCapitanPatitas heroeCapitanPatitas = new HeroeCapitanPatitas("Juan perez");
            Chapulin chapulin = new Chapulin("Roberto Gómez Bolaños");
            Merlin merlin = new Merlin("Merlin");
            Superman superman = new Superman("Clark Kent");

            //Habilidades de Superman
            Voladores.Add(superman);
            Velozes.Add(superman);
            Superfuertes.Add(superman);

            //Hablidades de Merli
            Magicos.Add(merlin);
            Invisibles.Add(merlin);

            //Habiladades de Chapulin
            Velozes.Add(chapulin);

            //Hablidades de capitan patitas
            Velozes.Add(heroeCapitanPatitas);
            Superfuertes.Add(heroeCapitanPatitas);

            //Todos los heroes
            todosLosHeroes.Add(heroeCapitanPatitas);
            todosLosHeroes.Add(chapulin);
            todosLosHeroes.Add(superman);
            todosLosHeroes.Add(merlin);

            Console.WriteLine("Habilidad de volar:");
            Console.WriteLine("--------------");
            foreach (IVolador heroe in Voladores)
            {
                if (heroe is Heroe heroeBase) // Visual me recomendo usar "patternmatching" para esta linea de codigo que verifica si el objeto heroe es una instancia de Heroe o una de sus subclases y creo la variable heroeBase.
                {
                    Console.WriteLine($"Heroe: {heroeBase.ObtenerNombre()}");
                    Console.WriteLine($"Nombre: {heroeBase.ObtenerIdentidad()}");
                    Console.WriteLine("--------------");
                }
            }

            Console.WriteLine("Habilidad de velocidad:");
            Console.WriteLine("--------------");
            foreach(IVeloz heroe in Velozes)
            {
                if(heroe is Heroe heroeBase)
                {
                    Console.WriteLine($"Heroe: {heroeBase.ObtenerNombre()}");
                    Console.WriteLine($"Nombre: {heroeBase.ObtenerIdentidad()}");
                    Console.WriteLine("--------------");
                }
            }

            Console.WriteLine("Habilidad de Fuerza:");
            Console.WriteLine("--------------");
            foreach (IFuerza heroe in Superfuertes)
            {
                if (heroe is Heroe heroeBase)
                {
                    Console.WriteLine($"Heroe: {heroeBase.ObtenerNombre()}");
                    Console.WriteLine($"Nombre: {heroeBase.ObtenerIdentidad()}");
                    Console.WriteLine("--------------");
                }
            }

            Console.WriteLine("Habilidad de Magia:");
            Console.WriteLine("--------------");
            foreach (IMagico heroe in Magicos)
            {
                if (heroe is Heroe heroeBase)
                {
                    Console.WriteLine($"Heroe: {heroeBase.ObtenerNombre()}");
                    Console.WriteLine($"Nombre: {heroeBase.ObtenerIdentidad()}");
                    Console.WriteLine("--------------");
                }
            }

            Console.WriteLine("Habilidad de invisibilidad:");
            Console.WriteLine("--------------");
            foreach (IInvisibilidad heroe in Invisibles)
            {
                if (heroe is Heroe heroeBase)
                {
                    Console.WriteLine($"Heroe: {heroeBase.ObtenerNombre()}");
                    Console.WriteLine($"Nombre: {heroeBase.ObtenerIdentidad()}");
                    Console.WriteLine("--------------");
                }
            }

            int heroesVoladores = 0;

            foreach (var heroe in todosLosHeroes)
            {
                if (heroe is IVolador)
                {
                    heroesVoladores++;
                }
            }
            Console.WriteLine($"Cantidad de héroes que pueden volar: {heroesVoladores}");
            Console.ReadKey();
        }
    }
}
