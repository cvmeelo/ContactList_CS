using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Contact contact = new Contact();
            ContactList contacts = new ContactList();

            contacts.loadContacts();
            bool exit = false; 
            int option = 0;
            string readTemp = "";

            Console.WriteLine( "Welcome to the Contact List App!\n\n" );

            do
            {
                Console.WriteLine("Please choose from the following menu: \n" +
                    "1 to Add a Contact\n" +
                    "2 to Print All Contacts\n" +
                    "3 to Print Contacts with a Last Name\n" +
                    "4 to Print Contacts with an Email\n" +
                    "5 to Print Contacts with a Zip Code\n" +
                    "6 to Save and Exit\n\n" );

                do
                {
                    Console.WriteLine("What would you like to do? ");
                    readTemp = Console.ReadLine();
                    int.TryParse(readTemp, out option);
                  
                } while (option < 1 || option > 6);

                switch (option)
                {
                    case 1:
                        contacts.addContact();
                        break;
                    case 2:
                        Console.WriteLine( contacts.ToString() );
                        break;
                    case 3:
                        Console.WriteLine("Enter Last Name: ");
                        readTemp = Console.ReadLine();
                        Console.WriteLine( contacts.writeContact( "last", readTemp ) );
                        break;
                    case 4:
                        Console.WriteLine("Enter Email: ");
                        readTemp = Console.ReadLine();
                        Console.WriteLine( contacts.writeContact( "email", readTemp ) );
                        break;
                    case 5:
                        Console.WriteLine("Enter Zip Code: ");
                        readTemp = Console.ReadLine();
                        Console.WriteLine( contacts.writeContact( "zip", readTemp ) );
                        break; 
                    case 6:
                        contacts.saveContacts();
                        exit = true;
                        break; 
                }

            } while( exit == false ); 
        }
    }
}
