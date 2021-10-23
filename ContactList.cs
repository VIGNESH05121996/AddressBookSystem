using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class ContactList
    {
        List<string> contact = new List<string>();
        public string firstName, lastName, address, city, state, zip, phoneNumber, email;
        public void ContList()
        {
            Console.WriteLine("Enter How Many Contacts You Want To Add To The Address Book");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    switch (j)
                    {
                        case 1:
                            Console.WriteLine("\nFirst Name:");
                            firstName = Convert.ToString(Console.ReadLine());
                            contact.Add(firstName);
                            break;

                        case 2:
                            Console.WriteLine("Last Name:");
                            lastName = Convert.ToString(Console.ReadLine());
                            contact.Add(lastName);
                            break;

                        case 3:
                            Console.WriteLine("Address:");
                            address = Convert.ToString(Console.ReadLine());
                            contact.Add(address);
                            break;

                        case 4:
                            Console.WriteLine("City:");
                            city = Convert.ToString(Console.ReadLine());
                            contact.Add(city);
                            break;

                        case 5:
                            Console.WriteLine("State:");
                            state = Convert.ToString(Console.ReadLine());
                            contact.Add(state);
                            break;

                        case 6:
                            Console.WriteLine("ZIP:");
                            zip = Convert.ToString(Console.ReadLine());
                            contact.Add(zip);
                            break;

                        case 7:
                            Console.WriteLine("Phone Number:");
                            phoneNumber = Convert.ToString(Console.ReadLine());
                            contact.Add(phoneNumber);
                            break;

                        case 8:
                            Console.WriteLine("Email:");
                            email = Convert.ToString(Console.ReadLine());
                            contact.Add(email);
                            break;

                        default:
                            Console.WriteLine("Details to be entered is out of range ");
                            break;

                    }
                }
                Console.WriteLine("\nAdded Contact List To The Address Book");
                Console.WriteLine("First Name:" + firstName + "\nLast Name:" + lastName + "\nAddress:" + address + "\nCity:" + city + "\nState:" + state + "\nZIP:" + zip + "\nPhone Number:" + phoneNumber + "\nEmail:" + email);
            }
        }
    }
}
