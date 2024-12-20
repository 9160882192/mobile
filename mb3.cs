using System;
using System.IO;

class FileReaderWriter
{
    static void Main(string[] args)
    {
        string path = "example.txt";

        // Write to a file
        File.WriteAllText(path, "Hello, this is a sample file content!");

        // Read from the file
        string content = File.ReadAllText(path);
        Console.WriteLine("File Content:");
        Console.WriteLine(content);
    }
}
