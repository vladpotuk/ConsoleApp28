using System;

namespace ConsoleApp27.Core
{
    public class Store
    {
        private string name;
        private string address;
        private string profileDescription;
        private string contactPhone;
        private string email;

        public void SetName(string value)
        {
            name = value;
        }

        public string GetName()
        {
            return name;
        }

        public void SetAddress(string value)
        {
            address = value;
        }

        public string GetAddress()
        {
            return address;
        }

        public void SetProfileDescription(string value)
        {
            profileDescription = value;
        }

        public string GetProfileDescription()
        {
            return profileDescription;
        }

        public void SetContactPhone(string value)
        {
            contactPhone = value;
        }

        public string GetContactPhone()
        {
            return contactPhone;
        }

        public void SetEmail(string value)
        {
            email = value;
        }

        public string GetEmail()
        {
            return email;
        }
    }
}
