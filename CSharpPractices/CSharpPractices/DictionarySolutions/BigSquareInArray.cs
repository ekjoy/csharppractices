using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractices.DictionarySolutions
{
	public class BigSquareInArray
	{

		public static int FindLargestSquare(int[] A)
		{
			int largestSquare = 0;
			int pivot = 2;
			bool skiped = false;
			for (int i = 0; i < A.Length; i++)
			{
				skiped = false;
				if (i != 0)
				{
					if (A[i] >= pivot)
					{
						for (int j = 1; j < pivot; j++)
						{
							if (A[i - j] < pivot)
							{
								 pivot=2;
								skiped = true;
								break;
							}
						}
						if (skiped == false)
						{
							if (pivot > largestSquare) largestSquare = pivot;
							pivot = pivot + 1;							
						}

					}
				}
				else
				{
					if (A[i] != 0)
					{
						largestSquare = 1;
					}
				}
				
			}

			return largestSquare;

		}


	}
}
