using System;
/*A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.*/
class PrintCompanyInfo
{
    static void Main()
    {
        //input from console
        Console.WriteLine("Fill the following fields");
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAdress = Console.ReadLine();
        Console.Write("Phone number: ");
        string companyPhoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string companyFaxNumber = Console.ReadLine();
        Console.Write("Company web site: ");
        string companyWebSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        string managerAge = Console.ReadLine();
        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();
        //end input
        Console.WriteLine(); //new line

        //format output string 
        string output = String.Format("{0} \nAdress: {1} \nTel. {2} \nFax: {3} \nWeb site: {4} \nManager: {5} {6} (age: {7}, tel. {8})", companyName, companyAdress,
            companyPhoneNumber, companyFaxNumber, companyWebSite, managerFirstName, managerLastName, managerAge, managerPhone);
        
        //replace empty fields with none
        output = output.Replace(":  ",": (none)");
       
        Console.WriteLine(output);
    }
}