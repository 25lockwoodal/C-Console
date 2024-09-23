
using System.Collections.Generic;
class Lists
{
    public static void List1(String[] args)
    {
        List<string> fruits = new List<string>();
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Orange");
    foreach (string fruit in fruits)
    {
        Console.WriteLine(fruit);
    }

    }
}