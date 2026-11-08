public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Create an array with the requested length
        double[] multiples = new double[length];

        // Loop through each position in the array
        for (int i = 0; i < length; i++)
        {
            // Calculate the multiple of the number
            // The first element should be number * 1,
            // the second should be number * 2, and so on
            multiples[i] = number * (i + 1);
        }

        // Return the completed array
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Create a temporary list to store the rotated values
        // This prevents us from overwriting values while rearranging them
        List<int> rotated = new List<int>();

        // Calculate the index where the rotation starts
        // The last 'amount' elements will move to the front
        int startIndex = data.Count - amount;

        // Copy the elements from startIndex to the end
        // of the original list into the temporary list
        for (int i = startIndex; i < data.Count; i++)
        {
            rotated.Add(data[i]);
        }

        // Copy the elements from the beginning of the
        // original list up to startIndex into the temporary list
        for (int i = 0; i < startIndex; i++)
        {
            rotated.Add(data[i]);
        }

        // Clear the original list
        data.Clear();

        // Add all values from the temporary list back
        // into the original list in their rotated order
        data.AddRange(rotated);
    }
}
