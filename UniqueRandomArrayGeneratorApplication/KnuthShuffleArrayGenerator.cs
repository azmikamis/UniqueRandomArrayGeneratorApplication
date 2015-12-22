using System;

namespace UniqueRandomArrayGeneratorApplication
{
    public class KnuthShuffleArrayGenerator : IUniqueRandomArrayGenerator
    {
        public int[] Generate(int n)
        {
            int[] array = new int[n];

            // fill array with sorted numbers
            for (int i = 0; i < n; i++)
                array[i] = i + 1;

            Random rnd = new Random();
            
            // apply Knuth Shuffle on sorted array
            for (int i = n - 1; i > 0; i--)
            {
                int r = rnd.Next(i + 1);
                Utilities.Swap(ref array[i], ref array[r]);
            }

            return array;
        }
    }
}
