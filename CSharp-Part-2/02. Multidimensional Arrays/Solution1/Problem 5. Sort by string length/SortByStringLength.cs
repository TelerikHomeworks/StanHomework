﻿using System;
using System.Linq;

class SortByStringLength
{
    static void Main()
    {
        string[] unsortedStrings = { "b", "aabbaaa", "aadsdwd", "a", "1256s", "wdasdwe" };
        //Using lambda functions
        foreach (var item in unsortedStrings.OrderBy(uStrings => uStrings.Length))
        {
            Console.WriteLine(item);
        }
    }
}
