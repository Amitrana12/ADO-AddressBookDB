using System;

namespace AddressBook_ADO_DB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Addrss Book with ADo.Net and sql server by Amit Rana");
            AddressBookrepo check = new AddressBookrepo();
            check.CheckConnection();
        }
    }
}
