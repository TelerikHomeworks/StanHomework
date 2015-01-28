using System;
/*Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
 * Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:*/
class CardCheck
{
    static void Main()
    {
        Console.Write("Enter a string ->> ");
        string card = Console.ReadLine();
        bool flag = false;
        switch (card)
        {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "J":
            case "Q":
            case "K":
            case "A": flag = true; break;
            default:
                break;
        }
        Console.WriteLine("Valid card sign? --> " + (flag? "yes" : "no"));
    }
}