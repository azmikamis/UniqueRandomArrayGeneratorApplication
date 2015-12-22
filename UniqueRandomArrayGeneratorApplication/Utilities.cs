namespace UniqueRandomArrayGeneratorApplication
{
    static class Utilities
    {
        /// <summary>
        /// Function to swap 2 numbers from left to right
        /// </summary>
        /// <param name="a">left number</param>
        /// <param name="b">right number</param>
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
