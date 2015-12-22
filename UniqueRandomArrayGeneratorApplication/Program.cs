using System;

namespace UniqueRandomArrayGeneratorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IUniqueRandomArrayGenerator generator = new KnuthShuffleArrayGenerator();
            int[] array = generator.Generate(1000);
            Console.WriteLine(string.Join(",", array));
        }
    }
}
