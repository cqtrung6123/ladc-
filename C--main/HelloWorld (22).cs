using System;

namespace Loop {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i >= -n; i--) {
                Console.Write(i + " ");
            }
        }
    }
}