using System;
using System.IO;

class Reader 
{
    public void read()
    {
        try
        {   // Open the text file using a stream reader.
            using (StreamReader sr = new StreamReader("input.txt"))
            {
            // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                Console.WriteLine(line);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}