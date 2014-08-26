using System;

class CompanyInfo
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        if (companyName == "") companyName="(no company name)";
        Console.Write("Company address: ");
        string companyAdress = Console.ReadLine();
        if (companyAdress == "") companyAdress = "(no company adress)";
        Console.Write("Phone number: ");
        string phoneNum = Console.ReadLine();
        if (phoneNum == "") phoneNum = "(no phone number)";
        Console.Write("Fax number: ");
        string faxNum = Console.ReadLine();
        if (faxNum == "") faxNum = "(no fax number)";
        Console.Write("Web site: ");
        string website = Console.ReadLine();
        if (website == "") website = "(no web site)";
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        if (managerFirstName == "") managerFirstName = "(no manager first name)";
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        if (managerLastName == "") managerLastName = "(no manager last name)";
        Console.Write("Manager age: ");
        string managerAge = Console.ReadLine();
        if (managerAge == "") managerAge = "(no manager age)";
        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();
        if (managerPhone == "") managerPhone = "(no manager phone)";
        
        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAdress);
        Console.WriteLine("Tel. {0}", phoneNum);
        Console.WriteLine("Fax: {0}", faxNum);
        Console.WriteLine("Web site: {0}", website);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
    }
}

