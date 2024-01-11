using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractices.DictionarySolutions
{
	public class NumberOfDistinctRowsInWall
	{
		public static int findNumberOfDistinctRows(int[] A)
		{
			// A[] = {2, 4, 6,1,2,3,0,1}  = 9
			/*
			  0
			  0
			 00
			 00  0
			000 00
			000000 0
			 
			 
			  */

			int count = 0;
			int prevVal = 0;

			Dictionary<int,int> d1 = new Dictionary<int,int>();
			for (int i = 0; i < A.Length; i++)
			{
				int pivot = A[i] - prevVal;
				if (pivot > 0)
				{
					count = count + pivot;
				}
				prevVal = A[i];
			}


			return count;
		}
	}
}
