﻿using System;

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
            /*data.first_name = "saurabh";
            data.last_name = "Gupta";
            data.address = "kotdwar";
            data.city = "Ruderpryag";
            data.state = "UP";
            data.zip = 723233;
            data.phone_number = "9879455434";
            data.email = "Aman1234@gmail.com";
            data.addressbook_name = "AddressBook1";
            data.addressbook_type = "Family";
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
            /* data.first_name = "sheetal";
             check.DeleteContactUsingName(data);*/


            // check.RetrievePersonFromPErticulatCityOrState();

          /// check.AddressBookSizeByCityANDState();

          //  check.SortPersonNameByCity();

            check.GetNumberOfPersonsCountByType();
        }
    }
}
