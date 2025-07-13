public static class MysteryStack1
{
    public static string Run(string text)
    {
        var stack = new Stack<char>(); // It creates a stack and stores it in a variable
        foreach (var letter in text) // Iterates every letter in the text parameter
            stack.Push(letter); // It pushes each letter into the stack

        var result = ""; // It creates a variable named result
        while (stack.Count > 0) // this is a while loop that will continue as long as stack.Count is not 0
            result += stack.Pop(); // I will remove the last letter that got into the stack and include it in result

        return result;
    }
}

//stressed => desserts