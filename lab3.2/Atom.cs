using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._2
{
    public class Atom
    {
        int i,end;
        
        Atom[] atoms = new Atom[4];
        public int number { get; set; }
        public string symbol { get; set; }
        public string fullName { get; set; }
       public float weight { get; set; }
        public Atom() { }
        public Atom(int number, string symbol, string fullName, float weight)
        {
            this.number = number;
            this.symbol = symbol;
            this.fullName = fullName;
            this.weight = weight;
        }
        public Boolean Accept()
        {
            atoms[i] = new Atom();
            Console.WriteLine("Enter atomic Number :");
            atoms[i].number = int.Parse(Console.ReadLine());
            if (atoms[i].number !=0)
            {
                Console.WriteLine("Enter Symbol :");
                atoms[i].symbol = Console.ReadLine();
                Console.WriteLine("Enter full Name :");
                atoms[i].fullName = Console.ReadLine();
                Console.WriteLine("Enter atom Weight :");
                atoms[i].weight = (float)float.Parse(Console.ReadLine());
                Console.WriteLine("=======================");
            }
            else
            {
                Console.WriteLine("No sym name weight");
                end=i;
                return false;
            }
            i++;
            return true;
        }
        public void Display()
        {
            for (int i = 0; i < end; i++)
            Console.WriteLine("{0} \t {1} \t {2} \t {3}",atoms[i].number, atoms[i].symbol, atoms[i].fullName, atoms[i].weight);
          
        }
    }
}
