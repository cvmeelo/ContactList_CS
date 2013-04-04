using System;
using System.Runtime.Serialization;

namespace ContactListApp
{
    [Serializable()]
    public class Contact : ISerializable
    {
        private string firstName;
        private string lastName;
        private string streetAddress;
        private string zipCode;
        private string email;
        private string phoneNumber;
        private string notes; 

        public Contact()
        {
            firstName = "";
            lastName = "";
            streetAddress = "";
            zipCode = "";
            email = "";
            phoneNumber = "";
            notes = "";
        }

        public void setFirstName(string fName)
        {
            firstName = fName;
        }

        public void setLastName(string lName)
        {
            lastName = lName;
        }

        public void setStreetAddress(string sAddress)
        {
            streetAddress = sAddress;
        }

        public void setZipCode(string zCode)
        {
            zipCode = zCode;
        }

        public void setEmail(string mail)
        {
            email = mail;
        }

        public void setPhoneNumber(string pNumber)
        {
            phoneNumber = pNumber;
        }

        public void setNotes(string note)
        {
            notes = note;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public string getStreetAddress()
        {
            return streetAddress;
        }

        public string getZipCode()
        {
            return zipCode;
        }

        public string getEmail()
        {
            return email;
        }

        public string getPhoneNumber()
        {
            return phoneNumber;
        }

        public string getNotes()
        {
            return notes;
        }

        public override string ToString()
        {
            string contact;
            contact = string.Format("{0} {1}\n{2}, {3}\n{4}, {5}\n{6}\n\n", 
                firstName, lastName, streetAddress, zipCode, email, phoneNumber, notes);
            return contact;
        }

        public Contact(SerializationInfo info, StreamingContext ctxt)
        {
            firstName = (string)info.GetValue("FirstName", typeof(string));
            lastName = (string)info.GetValue("LastName", typeof(string));
            streetAddress = (string)info.GetValue("StreetAddress", typeof(string));
            zipCode = (string)info.GetValue("ZipCode", typeof(string));
            email = (string)info.GetValue("Email", typeof(string));
            phoneNumber = (string)info.GetValue("PhoneNumber", typeof(string));
            notes = (string)info.GetValue("Notes", typeof(string));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("FirstName", firstName);
            info.AddValue("LastName", lastName);
            info.AddValue("StreetAddress", streetAddress);
            info.AddValue("ZipCode", zipCode);
            info.AddValue("Email", email);
            info.AddValue("PhoneNumber", phoneNumber);
            info.AddValue("Notes", notes);
        }
    }
}