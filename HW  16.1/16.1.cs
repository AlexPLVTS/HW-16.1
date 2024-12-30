class Program
{
    static void Main()
    {
        Console.Write("Enter the path to input file: ");
        string inputFilePath = Console.ReadLine();

        Console.Write("Enter the path to the file to copy in: ");
        string destinationFilePath = Console.ReadLine();

        try
        {
            if (!File.Exists(inputFilePath))
            {
                Console.WriteLine("Input file is not found");
                return;
            }
            File.Copy(inputFilePath, destinationFilePath, true);
            Console.WriteLine("File is successfully copied");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}