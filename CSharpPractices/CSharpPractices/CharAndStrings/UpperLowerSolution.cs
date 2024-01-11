using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractices.CharAndStrings
{
	public static class UpperLowerSolution
	{
		public static int Solution(string letters)
		{
			if (string.IsNullOrEmpty(letters)) return 0;

			HashSet<char> charsLower = new HashSet<char>();
			HashSet<char> charsUpper = new HashSet<char>();
			HashSet<char> charExceptions= new HashSet<char>();

			foreach (char c in letters)
			{

				if (Char.IsLower(c))
				{
					if (!charsLower.Contains(c))
						charsLower.Add(c);
					if (charsUpper.Contains(Char.ToUpper(c)))
					{
						if(!charExceptions.Contains(Char.ToUpper(c)))
							charExceptions.Add(Char.ToUpper(c));
					}
				}
				else if (Char.IsUpper(c))
				{
					if (!charsUpper.Contains(c))
						charsUpper.Add(c);
					if (!charsLower.Contains(Char.ToLower(c)))
					{
						if (!charExceptions.Contains(c))
							charExceptions.Add(c);
					}

				}

				
				
			}
			charsUpper.ExceptWith(charExceptions);
			return charsUpper.Count;
		}
	}
}
