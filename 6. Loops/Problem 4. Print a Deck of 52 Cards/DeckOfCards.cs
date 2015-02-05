using System;
/*Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
 */
class DeckOfCards
{
    static void Main()
    {
        for (int i = 1; i <= 13; i++)
        {

            for (int j = 1; j <= 4; j++)
            {
                switch (i)
                {
                    case 1: Console.Write("Ace"); break;
                    case 2: Console.Write("Two"); break;
                    case 3: Console.Write("Three"); break;
                    case 4: Console.Write("Four"); break;
                    case 5: Console.Write("Five"); break;
                    case 6: Console.Write("Six"); break;
                    case 7: Console.Write("Seven"); break;
                    case 8: Console.Write("Eight"); break;
                    case 9: Console.Write("Nine"); break;
                    case 10: Console.Write("Ten"); break;
                    case 11: Console.Write("Jack"); break;
                    case 12: Console.Write("Queen"); break;
                    case 13: Console.Write("King"); break;
                    default: Console.WriteLine("Something went wrong :)"); break;
                }
                switch (j)
                {
                    case 1: Console.WriteLine(" of Clubs"); break;
                    case 2: Console.WriteLine(" of Diamonds"); break;
                    case 3: Console.WriteLine(" of Hearts"); break;
                    case 4: Console.WriteLine(" of Spades"); break;
                    default: Console.WriteLine("Something went wrong :)"); break;
                }
            }
        }
    }
}