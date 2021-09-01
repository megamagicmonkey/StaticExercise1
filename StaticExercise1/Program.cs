using System;

namespace StaticExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TempConverter.CtoF(0));
            Console.WriteLine(TempConverter.CtoF(32.1));
            Console.WriteLine(TempConverter.FtoC(32));
            Console.WriteLine(TempConverter.FtoC(89.78));
        }
    }
}
