namespace _Binary_converter;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the image address: ");
        string address = Console.ReadLine();

        List<string> output = new List<string>();
        for (int i = 0; i < address.Length; i++)
        {
            output.Add(Convert.ToString((int)address[i], 2));
        }
        Console.Write("The address converted into binary code -> ");        
        Console.WriteLine(string.Join("", output));
    }
}

