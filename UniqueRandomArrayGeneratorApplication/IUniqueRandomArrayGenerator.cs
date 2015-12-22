namespace UniqueRandomArrayGeneratorApplication
{
    /// <summary>
    /// Interface to be implemented by different unique random array generators
    /// </summary>
    public interface IUniqueRandomArrayGenerator
    {
        /// <summary>
        /// Function to generate unique random array
        /// </summary>
        /// <param name="n">highest number in array of numbers from 1 to n</param>
        /// <returns>array with unique random numbers from 1 to n</returns>
        int[] Generate(int n);
    }
}
