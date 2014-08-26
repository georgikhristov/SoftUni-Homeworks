//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//•	First name
//•	Last name
//•	Age (0...100)
//•	Gender (m or f)
//•	Personal ID number (e.g. 8306112507)
//•	Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee 
//using appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;
class EmployeeData
{
    static void Main(string[] args)
    {
        string firstName = "Ivan";
        string lastName = "Ivanov";
        byte age = 35;
        string gender = "male";
        ulong personalIDNum = 8306112507;
        uint employeeNum = 27560000;
        Console.WriteLine(
            "First Name: {0}\nLast Name: {1}\nAge: {2}\nGender: {3}\nPersonal ID Number: {4}\nUnique Employee Number: {5}", 
            firstName,lastName,age,gender,personalIDNum,employeeNum );
    }
}