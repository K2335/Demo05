using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            // create Persons (collection)
            Persons myFriends = new Persons();

            // create a few Person objects
            Person person1 = new Person { Firstname = "Kirsi", Lastname = "Mainio", SocialSecurityNumber = "131415-1467" };
            Person person2 = new Person { Firstname = "Matti", Lastname = "Husso", SocialSecurityNumber = "313122-5134" };
            Person person3 = new Person { Firstname = "Teppo", Lastname = "Taistelija", SocialSecurityNumber = "365673-2312" };

            // add Person objects to Persons (myFriends)
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            // get one person
            Person person4 = myFriends.GetPerson(0);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }
            else
            {
                Console.WriteLine("There is no person at that position!");
            }

            // print collection
            myFriends.PrintData();

            // find person
            string socialSecurityNumber = "313122-5134";
            Console.WriteLine("Find person with social security number: " + socialSecurityNumber);
            Person person5 = myFriends.FindPerson(socialSecurityNumber);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
            else
            {
                Console.WriteLine("Can't find person with that social security number");
            }
        }
    }
}
