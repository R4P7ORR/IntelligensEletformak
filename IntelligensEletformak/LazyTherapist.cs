using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligensEletformak
{
	internal class LazyTherapist : Intelligens
	{
		private List<string> questionResponse = new List<string>() { "Biztos ön ebben ?", "Miért gondolja ezt ?", "El tudja képzelni ennek az ellenkezőjét is?", "Nem tudom.", "Talán így van.", "Ön mit gondol erről?" };
		private List<string> agitatedResponse = new List<string>() { "Most dühös lett?", "Mit érez miközben ezt mondja?", "Feszült lett attól, amiről beszélünk?" };
		private List<string> basicResponse = new List<string>() { "Kérem, folytassa", "Biztos ebben?", "Csakugyan?", "Hmm.", "Ez érdekes.", "Kérem fejtse ki bővebben!" };
		public string Answer(string input)
		{
			Random r = new Random();
			if (input.EndsWith("?"))
			{
				return $"Lazy Therapist: {questionResponse[r.Next(0,6)]}";
			}
			else if (input.EndsWith("!"))
			{
				return $"Lazy Therapist: {agitatedResponse[r.Next(0,3)]}";
			}
			else 
			{ 
				return $"Lazy Therapist: {basicResponse[r.Next(0,6)]}";
			}
		}
	}
}
