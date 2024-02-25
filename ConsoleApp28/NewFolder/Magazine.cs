using System;

namespace ConsoleApp27.Core
{
    public class Magazine
    {
        private string title;
        private int foundationYear;
        private string description;
        private string contactPhone;
        private string email;

        public void SetTitle(string value)
        {
            title = value;
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetFoundationYear(int value)
        {
            foundationYear = value;
        }

        public int GetFoundationYear()
        {
            return foundationYear;
        }

        public void SetDescription(string value)
        {
            description = value;
        }

        public string GetDescription()
        {
            return description;
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
