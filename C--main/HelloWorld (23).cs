using System;

namespace Loop {
    class Program {
        static void Main(string[] args) {
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int answer = 0;
			for (int i = a; i <= b; i++) {
				// answer += i means answer = answer + i
				answer += i;
			}
			Console.WriteLine(answer);
		}
    }
}