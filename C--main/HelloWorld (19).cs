using System;

namespace Statement {
    class Program {
        static void Main(string[] args) {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a <= b && b <= c) {
                Console.WriteLine("increasing");
            } else if (a >= b && b >= c) {
                Console.WriteLine("decreasing");
            } else {
                Console.WriteLine("neither increasing nor decreasing order");
            }
        }
    }
}