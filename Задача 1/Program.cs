using System;
namespace Basic_concepts_C_Sharp {
    class Program {
        static void Main(string[] args) {
            int Degree, Input, Result;
            Console.Write("Введите число: ");
            Input = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите степень числа: ");
            Degree = Convert.ToInt32(Console.ReadLine());
            Result = Input;
            for (int Step = 1; Step < Degree; ++Step) {
                Result *= Input;
            }
            Console.WriteLine(Result);
        }
    }
}
