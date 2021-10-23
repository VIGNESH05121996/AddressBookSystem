using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book");
            ContactList clist1 = new ContactList();
            clist1.ContList();
            clist1.EditDetails("vignesh");
        }
    }
}
