using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractices.LinkedLists
{
	public  class LinkedListNode
	{
		public int Value;
		public LinkedListNode? Next;

		public LinkedListNode(int value)
		{
			Value = value;			
		}
	}
}
