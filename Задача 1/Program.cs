using System;
namespace Basic_concepts_C_Sharp {
    class Program {
        static void Main(string[] args) {
            int n, a, Result;
            Console.Write("Введите число a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Result = a;
            for (int Step = 1; Step < n; ++Step) {
                Result *= a;
            }
            Console.WriteLine(result);
        }
    }
}
