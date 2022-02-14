using System;
namespace Basic_concepts_C_Sharp {
    class Program {
        static void Main(string[] args) {
            String Input, Result;
            Result = "";
            Console.Write("Введите число:");
            Input = Console.ReadLine();
            for (int Step = 0; Step < Input.Length; Step++) {
                if (Step == 1) {
                    continue;
                }
                Result += Input[Step];
            }
            Result += Input[1];
            Console.WriteLine(Result);
        }
    }
}
