using System;
//A bank account has a holder name (first name, middle name and last name), 
//available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account
//using the appropriate data types and descriptive names.
class BankAccount
{
    static void Main(string[] args)
    {
        string holderFirstName;
        string holderMiddleName;
        string holderLastName;
        decimal balance;
        string bankName;
        string IBAN;
        long creditCardNumber1;
        long creditCardNumber2;
        long creditCardNumber3;

        holderFirstName = "Stiliyan";
        holderMiddleName = "Sergeev";
        holderLastName = "Stanev";
        balance = 6000042.23M;
        bankName = "DSK";
        IBAN = "BG66STSA12345678912345";
        creditCardNumber1 = 2776825078823332;
        creditCardNumber2 = 3218534291277922;
        creditCardNumber3 = 2317954165132179;

        Console.WriteLine(@"
        Name: {0} {1} {2}
        Balance: {3:C}
        Bank Name: {4}
        IBAN: {5}
        Credit Card Number 1: {6}
        Credit Card Number 2: {7}
        Credit Card Number 3: {8}
                                 ", holderFirstName, holderMiddleName, holderLastName, balance, bankName,
                          IBAN, creditCardNumber1, creditCardNumber2, creditCardNumber3);
    }
}