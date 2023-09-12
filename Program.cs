using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freeformpractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            rnd.Next(1,10);
            int eleccion;
            int eleccion2;
            int i = 0;
            int puntaje = 0;
            int puntaje2 = 0;  
            Console.WriteLine("Versus,3 cartas contra 3 cartas al azar");
            int[] player1 = { rnd.Next(1,10), rnd.Next(1 , 10), rnd.Next(1, 10) };
            int[] player2 = { rnd.Next(1 , 10), rnd.Next(1 , 10), rnd.Next(1 , 10) };
            Console.WriteLine("player 1 estas son tus cartas:");
            Console.WriteLine(player1[0]);
            Console.WriteLine(player1[1]);
            Console.WriteLine(player1[2]);
            Console.WriteLine("player 2 estas son tus cartas:");
            Console.WriteLine(player2[0]);
            Console.WriteLine(player2[1]);
            Console.WriteLine(player2[2]);

            for(i= 0; i <= 2; i++) 
            {
                Console.WriteLine("player 1 elegi");
                eleccion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("player 2 elegi");
                eleccion2 = Convert.ToInt32(Console.ReadLine());

                if (eleccion > eleccion2) 
                {
                    puntaje += 1;
                    Console.WriteLine("player 1 se lleva esta ronda");
                }
                else if (eleccion < eleccion2) 
                {
                    puntaje2 += 1;
                    Console.WriteLine("player 2 se lleva esta ronda");
                }
                else
                {
                    Console.WriteLine("Empataron esta ronda");
                }

            }

            if (puntaje > puntaje2) 
            {
                Console.WriteLine("GANO EL JUGADOR 1");
            }
            else if(puntaje < puntaje2)
            {
                Console.WriteLine("GANO EL JUGADOR 2");
            }
            else 
            {
                Console.WriteLine("EMPATARON");
            }
            Console.ReadKey();

        }
    }
}
