using System.Collections.Generic;
using System;
using ConsoleApp3;

public class Node
{
    public int data;
    public Node next;

    public Node(int i)
    {
        data = i;
        next = null;
    }

    public void Print()
    {
        Console.Write("|" + data + "| -->");
        if (next != null)
        {
            next.Print();
        }
    }
    public void AddToEnd(int i)
    {

        if (next == null)
        {
            next = new Node(i);
        }
        else
        {
            next.AddToEnd(i);
        }
    }

    
}

public class Mylist
{
    public Node headNode;

    public Mylist() 
    {
        headNode = null;
    }
    public void AddToFirst(int i)
    {

        if (headNode == null)
        {
            headNode = new Node(i);
        }
        else
        {
            Node tempNode = new Node(i);

            tempNode.next = headNode;
            headNode = tempNode;

        }
    }
    
    public void Print() 
    {
        if (headNode != null)
        { 
          headNode.Print();
        }
    }
}

public class Program 
{


    public static void Main(string[] args)
    {
        //Mylist mynext = new Mylist();
        //mynext.AddToFirst(2);
        //mynext.AddToFirst(3);
        //mynext.AddToFirst(4);
        //mynext.AddToFirst(5);
        //mynext.AddToFirst(6);


        //mynext.Print();
        //MaxSum  d = new MaxSum();


        //int[] arr = { 34, -50, 42, 14, -5, 86 };
        //Console.WriteLine(d.sum(arr));



        //int[] arr = { 3, 5, 22, 8, 12, 15, 17, 20, 0 };
        //string s = Practice.Operationstoknow(arr, 17);
        //string[] arr = { "san", "har","ind"};
        //List<string> list = new List<string>(arr);
        //LinkedList<string> ls = new LinkedList<string>(list);

        //LinkedListNode<string> node = ls.Find("har");

        //ls.AddBefore(node,"san2");
        //ls.AddAfter(node, "san2");
        //ls.AddFirst("san2");
        //ls.AddLast("san2");
        //ls.Remove("san2");
        //ls.RemoveFirst();
        //foreach (var value in ls)
        //    Console.Write("|" + value + "| -->");

        //Twosum d = new Twosum();

        //int[] a = { 3, 2, 3 };

        //foreach (int n in d.TwoSum(a, 6))
        //    Console.WriteLine(n);
        //Practice.Operationstoknow();
        //Anagrams d = new Anagrams();
        //bool c = d.IsAnagram("rrat","car");
        int[] arr = {-1, 0, 1, 2, -1, -4};

        ThreeSum.ThreeNumberSum(arr,0);

        

        //Console.WriteLine();
        Console.ReadLine();
    }
}