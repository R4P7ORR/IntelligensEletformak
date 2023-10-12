using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligensEletformak
{
	internal class DullTherapist : Intelligens
	{
		private List<string> answerList = new List<string>() { "Kérem, folytassa", "Biztos ebben ?", "Csakugyan ?", "Nem tudom.","Talán így van.","Ön mit gondol erről ?" };

		public string Answer(string input)
		{
			Random r = new Random();
			return $"Dull Therapist: {answerList[r.Next(0,6)]}";
		}
	}
}
