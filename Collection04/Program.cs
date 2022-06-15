// See https://aka.ms/new-console-template for more information

using System.Collections;

class Product{
    string name;
    double cost;
    int onhand;
    public Product(string n, double c, int h)
    {
        name = n;
        cost = c;
        onhand = h;
    }
    public override string ToString()
    {
        return String.Format("{0,-10}Cost: {1,6:C} On Hand:{2}",name,cost,onhand);
    }
}
class program
{
    public static void Main()
    {
        ArrayList inv = new ArrayList();
        //add element to the list
        inv.Add(new Product("A", 5.9, 3));//productp1=new product(,,);
        inv.Add(new Product("B", 8.2, 2));
        inv.Add(new Product("C", 3.5, 4));
        inv.Add(new Product("D", 1.8, 8));
        Console.WriteLine("Product list");
        foreach(Product i in inv)
        {
            Console.WriteLine(" " + i);

        }
    }
}
public class Programs
{
    public static void Main()
    {
        SortedList objSL = new SortedList();
        objSL.Add("4", "!");
        objSL.Add("3", "Brilliant");
        objSL.Add("2", "am");
        objSL.Add("1", "I");
        Console.WriteLine("Number of Elements in objSL : {0}", objSL.Count);
        Console.WriteLine("\t-KEY-\t-VALUE-");
        for (int i = 0; i < objSL.Count; i++)
        {
            Console.WriteLine("\t{0}:\t{1}", objSL.GetKey(i),
            objSL.GetByIndex(i));
        }
        Console.ReadLine();
    }
}
class Programss
{
    public static void Main()
    {
        Hashtable ht = new Hashtable();
        ht.Add("a", "A");
        ht.Add("b", "B");
        ht.Add("c", "C");
        ht.Add("e", "E");
        ht["f"] = "F";
        // Get a collection of the keys.
        ICollection c = ht.Keys;
        foreach (string str in c)
            Console.WriteLine(str + ": " + ht[str]);
    }
}


