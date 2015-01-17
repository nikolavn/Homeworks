using System;
  
class PrintCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Enter company name:");
        string companyName = Console.ReadLine();

        Console.WriteLine("Enter company address:");
        string companyAddress = Console.ReadLine();

        Console.WriteLine("Enter company phone number:");
        uint companyPhone = uint.Parse(Console.ReadLine());

        Console.WriteLine("Enter company fax number:");
        uint companyFax = uint.Parse(Console.ReadLine());

        Console.WriteLine("Enter company web site:");
        string companyWeb = Console.ReadLine();

        Console.WriteLine("Enter manager's first name:");
        string managerFName = Console.ReadLine();

        Console.WriteLine("Enter manager's last name:");
        string managerLName = Console.ReadLine();

        Console.WriteLine("Enter manager's age:");
        byte managerAge = byte.Parse(Console.ReadLine());

        Console.WriteLine("Enter manager's phone:");
        uint managerPhone = uint.Parse(Console.ReadLine());

        Console.WriteLine(companyName);
        Console.WriteLine("Adress: ",companyAddress);
        Console.WriteLine("Tel. {0:+359 ### ## ## ###}",companyPhone);
        Console.WriteLine(companyFax.ToString().Length < 9 ? "Fax: {0:(359) 0# ### ## ##}":"Fax: (no fax)",companyFax);
        Console.WriteLine("Web site: {0}", companyWeb);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel.{3:+359 # ### ###})",managerFName,managerLName,managerAge,managerPhone);
    }
}

