using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace ContactListApp
{
    class ContactList
    {
        List<Contact> list = new List<Contact>();

        public void addContact()
        {
            Contact contactTemp = new Contact();

            Console.WriteLine("Enter First Name: ");
            contactTemp.setFirstName(Console.ReadLine());
            Console.WriteLine("Enter Last Name: ");
            contactTemp.setLastName(Console.ReadLine());
            Console.WriteLine("Enter Street Address: ");
            contactTemp.setStreetAddress(Console.ReadLine());
            Console.WriteLine("Enter Zip Code: ");
            contactTemp.setZipCode(Console.ReadLine());
            Console.WriteLine("Enter Email: ");
            contactTemp.setEmail(Console.ReadLine());
            Console.WriteLine("Enter Phone Number: ");
            contactTemp.setPhoneNumber(Console.ReadLine());
            Console.WriteLine("Enter Notes: ");
            contactTemp.setNotes(Console.ReadLine());

            Console.WriteLine("\n");

            list.Add(contactTemp);
        }

        public string writeContact(string type, string value)
        {
            int count = 0;
            string contactString = ""; 

            if (list.Count == 0)
            {
                return "No Contacts Found\n";
            }
            else
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    if (type == "last")
                    {
                        if (value == list[i].getLastName())
                        {
                            contactString += list[i].ToString();
                            count++;
                        }
                    }
                    else if (type == "email") 
                    {
                        if (value == list[i].getEmail())
                        {
                            contactString += list[i].ToString();
                            count++;
                        }
                    }
                    else if (type == "zip")
                    {
                        if (value == list[i].getZipCode())
                        {
                            contactString += list[i].ToString();
                            count++;
                        }
                    }
                }

            }

            if (count == 0)
            {
                return "No Contact Found\n";
            }
            else
            {
                return contactString; 
            }
        }

        public override string ToString()
        {
            string contactString = "";

            if (list.Count == 0)
            {
                return "No Contacts Found\n"; 
            }
            else
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    contactString += list[i].ToString();
                }

                return contactString;
            }
        }

        public void saveContacts()
        {
            Stream stream = File.Open("contactList.dat", FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();
            bformatter.Serialize(stream, list);
            stream.Close();

        }

        public void loadContacts()
        {
            if (File.Exists("contactList.dat"))
            {
                Stream stream = File.Open("contactList.dat", FileMode.Open);
                BinaryFormatter bformatter = new BinaryFormatter();

                if (stream.Length > 0)
                {
                    list = (List<Contact>)bformatter.Deserialize(stream);
                }

                stream.Close();
            }
        }

    }
}
