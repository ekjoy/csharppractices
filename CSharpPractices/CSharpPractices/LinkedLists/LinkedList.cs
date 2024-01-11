using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractices.LinkedLists
{
	public  class LinkedList
	{
		public LinkedList() { }
		public LinkedListNode? head; 
		public LinkedListNode? tail;

		public void  AddItem(int item)
		{
			if (head == null)
				head = new LinkedListNode(item);
			else
			{
				var currentNode = head;
				while (currentNode.Next != null)
				{					
					currentNode = currentNode.Next;
				}
				currentNode.Next= new LinkedListNode(item);
			}

		}

		public void RevereseList()
		{
			
			LinkedListNode Prev = null;
			LinkedListNode Temp = null;
			LinkedListNode current = head;

			while (current != null)
			{
				Temp = current.Next;
				current.Next = Prev;
				Prev = current;
				current = Temp;

			}
			head = Prev;


		}

		public void PrintItems()
		{
			var currentNode = head;
			while (currentNode != null)
			{
				Console.WriteLine(String.Format("Value is : {0}", currentNode?.Value));
				currentNode = currentNode?.Next;
			}

			Console.ReadLine();
		}


	}
}
