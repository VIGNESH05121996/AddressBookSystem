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
            for (int i = 1; i <= 8; i++)
            {
                switch (i)
                {
                    case 1:
                        firstName = "VIGNESH";
                        contact.Add(firstName);
                        break;

                    case 2:
                        lastName = "MUTHU";
                        contact.Add(lastName);
                        break;

                    case 3:
                        address = "HAPP";
                        contact.Add(address);
                        break;

                    case 4:
                        city = "TRICHY";
                        contact.Add(city);
                        break;

                    case 5:
                        state = "TAMIL NADU";
                        contact.Add(state);
                        break;

                    case 6:
                        zip = "620025";
                        contact.Add(zip);
                        break;

                    case 7:
                        phoneNumber = "123456789";
                        contact.Add(phoneNumber);
                        break;

                    case 8:
                        email = "vicky@gmail.com";
                        contact.Add(email);
                        break;

                    default:
                        Console.WriteLine("\nCannot Display Details");
                        break;

                }
            }
            Console.WriteLine("First Name:" + firstName + "\nLast Name:" + lastName + "\nAddress:" + address + "\nCity:" + city + "\nState:" + state + "\nZIP:" + zip + "\nPhone Number:" + phoneNumber + "\nEmail:" + email);
        }
    }
}
