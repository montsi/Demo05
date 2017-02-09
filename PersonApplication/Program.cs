using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new Person objects
            Person person1 = new Person { FirstName = "Kirsi", LastName = "Mainio", SocialSecurityNumber = "112312-1232"};
            Person person2 = new Person { FirstName = "Matti", LastName = "Husso", SocialSecurityNumber = "102210-1432"};
            Person person3 = new Person { FirstName = "Teppo", LastName = "Taistelija", SocialSecurityNumber = "052306-4232"};

            // create a Persons object
            Persons myFriends = new Persons();

            // add person objects to persons collection
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            // get one person from Persons collection
            Person person4 = myFriends.GetPerson(10);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            } else
            {
                Console.WriteLine("Person not found in that index!");
            }

            // print collection
            myFriends.PrintCollection();

            // find person
            string sotu = "112312-1232";
            Console.WriteLine("Find sotu: " + sotu);
            Person person5 = myFriends.FindPerson(sotu);
            if(person5 != null)
            {
                Console.WriteLine(person5.ToString());
            } else
            {
                Console.WriteLine("Cant find person with that sotu..");
            }
        }
    }
}
