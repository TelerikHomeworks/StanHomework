using System;
using System.Collections.Generic;
using System.Text;

class PrintASCII
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        for (int i = 0; i <= 255; i++)
        {
            if (i >= 127 && i <= 160)
            {
                System.Console.WriteLine("{0} = :)", i);
            }
            else
            {
                System.Console.WriteLine("{0} = {1}", i, (char)i);
            }

        }
    }
}
