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
            AddressBookModel data = new AddressBookModel();
            //insert data
           /* data.first_name = "sumit";
            data.last_name = "semwal";
            data.address = "tilwada";
            data.city = "Ruderpryag";
            data.state = "Uk";
            data.zip = 523233;
            data.phone_number = "9879325434";
            data.email = "Sumit1234@gmail.com";
            data.addressbook_name = "AddressBook1";
            data.addressbook_type = "Profession";
            check.Addcontatct(data);*/

            /// edit contact
            /*data.first_name = "Neha";
            data.last_name = "Patil";
            data.city = "Pushkar";
            data.state = "Rajasthan";
            data.email = "Neha432@gmail.com";
            data.addressbook_name = "AddressBook1";
            data.addressbook_type = "Professional";
            check.EditContactUsingPersonName(data);
*/
            ///Deletcontact by First name 
            data.first_name = "sheetal";
            check.DeleteContactUsingName(data);

        }
    }
}
