using System;

namespace ConsoleApp27.Core
{
    public class Website
    {
        private string title;
        private string path;
        private string description;
        private string ipAddress;

        public void SetTitle(string value)
        {
            title = value;
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetPath(string value)
        {
            path = value;
        }

        public string GetPath()
        {
            return path;
        }

        public void SetDescription(string value)
        {
            description = value;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetIpAddress(string value)
        {
            ipAddress = value;
        }

        public string GetIpAddress()
        {
            return ipAddress;
        }
    }
}
