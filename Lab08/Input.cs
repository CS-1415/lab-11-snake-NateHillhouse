namespace Lab08;
public static class InputValidation
{
    public static int GetInt(string message, int? size = null)
    {
        int num = 0;
        Console.Write(message);
        string? input = Console.ReadLine();
        while (input == null || !Int32.TryParse(input, out num) || num > size || num <= 0) 
        {
            return GetInt("Please enter a valid number: ", size);
        }
        return num;
    }
}