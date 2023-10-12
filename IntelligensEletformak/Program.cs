using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligensEletformak
{
	internal class Program
	{
		static void Main(string[] args)
		{ 
			Console.WriteLine("Parrot:");
			Parrot p1 = new Parrot();
            Console.WriteLine(p1.Answer(Console.ReadLine()));

            Console.WriteLine("\nDull Therapist:");
            DullTherapist d1 = new DullTherapist();
            Console.WriteLine(d1.Answer(Console.ReadLine()));
            Console.WriteLine(d1.Answer(Console.ReadLine()));

            Console.WriteLine("\nLazy Therapist");
            LazyTherapist l1 = new LazyTherapist();
            Console.WriteLine(l1.Answer(Console.ReadLine()));
            Console.WriteLine(l1.Answer(Console.ReadLine()));
			Console.WriteLine(l1.Answer(Console.ReadLine()));
			Console.WriteLine(l1.Answer(Console.ReadLine()));


			Console.ReadKey();
		}
	}
}
