using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main()
    {
        int counter = 0;
        Console.WriteLine("Enter the text - ");

       
        foreach (char c in Console.ReadLine())
        {
          switch (c)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':

                    counter++;
                    break;
            }
        }
        Console.WriteLine(counter);
    }

}
