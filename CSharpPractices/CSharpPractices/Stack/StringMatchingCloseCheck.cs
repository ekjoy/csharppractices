using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharpPractices.Stacks
{
	public class StringMatchingCloseCheck
	{

		public StringMatchingCloseCheck() { }

		public static bool checkIfMatched(string stringVal)
		{
			bool returnVal = true;
			Stack myStack = new Stack();
			char[] ch= stringVal.ToCharArray();
			foreach (char c in ch)
			{
				if (c=='{' || c== '(')
					myStack.Push(c);
				if (c == '}')
				{
					if (myStack.Count > 0)
					{
						var pk = myStack.Peek();
						if (pk is not null and (object)'{')
							myStack.Pop();
					}
					else
					{
						myStack.Push(c);
					}
				}
				else if (c == ')')
				{
					if (myStack.Count > 0)
					{
						var pk = myStack.Peek();
						if (pk is not null and (object)'(')
							myStack.Pop();
					}
					else
					{
						myStack.Push(c);
					}
				}
			}
			if(myStack.Count == 0)
				returnVal=true; else returnVal=false;

			return returnVal;
		}

	}
}
