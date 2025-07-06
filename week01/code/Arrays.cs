using System.Diagnostics;

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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // 1. I create a new array so it can be returned
        double[] result = new double[length];

        // 2. I start a loop that will get the multiples of number until and be included in the new array until it reached a length equal to the parameter length
        for (var i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        // 3. The array is returned.
        return result; 
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // 1. I create two arrays, the first one to hold the firstt numbers in the final array and the other one to hold the last ones
        // 2. I use the GetRange method to get both parts, array1 will be the first part of the resulting array.
        List<int> array1 = data.GetRange(data.Count - amount, amount);
        List<int> array2 = data.GetRange(0, data.Count-amount);

        // 3. Since we're not returning anything I just clear the given data list.
        data.Clear();

        // 4. Finally I put the two arrays togethers so they become one.
        data.AddRange(array1);
        data.AddRange(array2);
    }
}
