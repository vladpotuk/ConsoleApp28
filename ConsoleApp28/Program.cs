using ConsoleApp27.Core;
using System;

class Program
{
    static void Main()
    {
        // Завдання 4 - Веб-сайт
        Website myWebsite = new Website();
        Console.WriteLine("Enter Website Information:");
        Console.Write("Title: ");
        myWebsite.SetTitle(Console.ReadLine());
        Console.Write("Path: ");
        myWebsite.SetPath(Console.ReadLine());
        Console.Write("Description: ");
        myWebsite.SetDescription(Console.ReadLine());
        Console.Write("IP Address: ");
        myWebsite.SetIpAddress(Console.ReadLine());

        Console.WriteLine("\nWebsite Information:");
        Console.WriteLine($"Title: {myWebsite.GetTitle()}");
        Console.WriteLine($"Path: {myWebsite.GetPath()}");
        Console.WriteLine($"Description: {myWebsite.GetDescription()}");
        Console.WriteLine($"IP Address: {myWebsite.GetIpAddress()}");
        Console.WriteLine();

        // Завдання 5 - Журнал
        Magazine myMagazine = new Magazine();
        Console.WriteLine("Enter Magazine Information:");
        Console.Write("Title: ");
        myMagazine.SetTitle(Console.ReadLine());
        Console.Write("Foundation Year: ");
        myMagazine.SetFoundationYear(int.Parse(Console.ReadLine()));
        Console.Write("Description: ");
        myMagazine.SetDescription(Console.ReadLine());
        Console.Write("Contact Phone: ");
        myMagazine.SetContactPhone(Console.ReadLine());
        Console.Write("Email: ");
        myMagazine.SetEmail(Console.ReadLine());

        Console.WriteLine("\nMagazine Information:");
        Console.WriteLine($"Title: {myMagazine.GetTitle()}");
        Console.WriteLine($"Foundation Year: {myMagazine.GetFoundationYear()}");
        Console.WriteLine($"Description: {myMagazine.GetDescription()}");
        Console.WriteLine($"Contact Phone: {myMagazine.GetContactPhone()}");
        Console.WriteLine($"Email: {myMagazine.GetEmail()}");
        Console.WriteLine();

        // Завдання 6 - Магазин
        Store myStore = new Store();
        Console.WriteLine("Enter Store Information:");
        Console.Write("Name: ");
        myStore.SetName(Console.ReadLine());
        Console.Write("Address: ");
        myStore.SetAddress(Console.ReadLine());
        Console.Write("Profile Description: ");
        myStore.SetProfileDescription(Console.ReadLine());
        Console.Write("Contact Phone: ");
        myStore.SetContactPhone(Console.ReadLine());
        Console.Write("Email: ");
        myStore.SetEmail(Console.ReadLine());

        Console.WriteLine("\nStore Information:");
        Console.WriteLine($"Name: {myStore.GetName()}");
        Console.WriteLine($"Address: {myStore.GetAddress()}");
        Console.WriteLine($"Profile Description: {myStore.GetProfileDescription()}");
        Console.WriteLine($"Contact Phone: {myStore.GetContactPhone()}");
        Console.WriteLine($"Email: {myStore.GetEmail()}");
    }
}
