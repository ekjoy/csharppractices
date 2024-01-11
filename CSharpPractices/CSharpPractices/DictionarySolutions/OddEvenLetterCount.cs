using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractices.DictionarySolutions
{
	public class OddEvenLetterCount
	{
		public static int FindOddCharacters(string val)
		{

			int result = 0;
			Dictionary<char, int> d1 = new Dictionary<char, int>();
			foreach (char c in val)
			{
				if (d1.ContainsKey(c))
				{
					int k = d1[c];
					d1[c] = k + 1;
				}
				else
				{
					d1.Add(c, 1);
				}
			}

			foreach (var d in d1)
			{
				if (d.Value % 2 != 0)
				{
					result++;
				}
			}



			return result;

		}
	}
}
