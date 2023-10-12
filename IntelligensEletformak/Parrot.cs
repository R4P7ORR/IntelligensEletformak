using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IntelligensEletformak
{
	internal class Parrot : Intelligens
	{
		public string Answer(string input)
		{
			return $"Parrot: {input}";
		}
	}
}
