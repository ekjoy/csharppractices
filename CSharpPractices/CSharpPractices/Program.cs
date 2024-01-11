// See https://aka.ms/new-console-template for more information
using CSharpPractices.CharAndStrings;
using CSharpPractices.DictionarySolutions;
using CSharpPractices.LinkedLists;
using CSharpPractices.Stacks;

Console.WriteLine("Hello, World!");

Console.WriteLine("Enter Name :");

var Name =Console.ReadLine();
Console.WriteLine("Your Name is {0}", Name);
Console.ReadLine();

//LinkedList linkedList = new LinkedList();
//linkedList.AddItem(1);
//linkedList.AddItem(2);
//linkedList.AddItem(3);
//linkedList.PrintItems();
//linkedList.RevereseList();
//linkedList.PrintItems();

//int[] lst = { 1, 2, 3, 4, 5 };
//Array.Sort(lst);
/****************************/
//Console.WriteLine("Enter String :");
//var s = Console.ReadLine();
//bool matched = StringMatchingCloseCheck.checkIfMatched(s);
//if (matched)
//	Console.WriteLine("Matched");
//else
//	Console.WriteLine("Not Matched");

/*******************************/
//int[] A = { 1,3,2,1,2,1,5,3,3,4,2};
//int k =NumberOfDistinctRowsInWall.findNumberOfDistinctRows(A);
//Console.WriteLine(String.Format("Number of distinct rows = {0}",k));

/***********************************/
Console.WriteLine("enter string :");
var s = Console.ReadLine();
int k = UpperLowerSolution.Solution(s);
Console.WriteLine(String.Format("Number of odd letters = {0}", k));


///**************************************/
//int[] A = { 1,2,5,3,1,3 };
//int k1 = BigSquareInArray.FindLargestSquare(A);
//Console.WriteLine(String.Format("Largest Square is  = {0}", k1));
////Console.WriteLine(String.Format("Largest Square is  = {0}", k1));

Console.ReadLine();




