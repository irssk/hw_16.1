using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter the path to the source file: ");
        string sourcePath = Console.ReadLine();

        Console.Write("Enter the path to the file you want to copy the data to: ");
        string destinationPath = Console.ReadLine();

        try
        {
            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("The source file does not exist.");
                return;
            }

            File.Copy(sourcePath, destinationPath, true);

            Console.WriteLine("File copied successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while copying the file:");
            Console.WriteLine(ex.Message);
        }
    }
}
