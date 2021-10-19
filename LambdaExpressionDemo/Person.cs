using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaExpressionDemo
{
    public class Person
    {
        public string SSN;
        public string name;
        public string address;
        public int age;

        public Person(string SSN, string name, string address, int age)
        {
            this.SSN = SSN;
            this.name = name;
            this.address = address;
            this.age = age;
        }

        /* List<Person> listPerson = new List<Person>();
         listPerson.*/

        public static void AddMembers(List<Person> listPerson)
        {
            listPerson.Add(new Person("10001", "Arun", "Gadag", 14));
            listPerson.Add(new Person("10002", "Vijay", "Hubli", 35));
            listPerson.Add(new Person("10003", "Harsha", "Bangalore", 18));
            listPerson.Add(new Person("10004", "Yogi", "Bagalkot", 60));
            listPerson.Add(new Person("10005", "CHetan", "Raychur", 65));
        }

        public static void RetrivePersonAgeIsLessThanSixty(List<Person> listPerson)
        {
            foreach (Person person in listPerson.FindAll(x => (x.age <= 60)).Take(2).ToList())
            {
                Console.WriteLine("Name: " + person.name + " (Age)" + person.age);
            }
        }

        public static void RetriveAllPersonAgeIsBetween13to18(List<Person> listPerson)
        {
            /*foreach (Person person in listPerson.FindAll(x => (x.age > 13 && x.age <= 18)).ToList())
            {
                Console.WriteLine("Name: " + person.name + " (Age)" + person.age);
            }*/

            if(listPerson.Any(x => (x.age > 13 && x.age <= 18)))
            {
                Console.WriteLine("Present");
            }
        }

        public static void RetriveAllPersonAverageAge(List<Person> listPerson)
        {
            /*foreach (Person person in listPerson.FindAll(x => (x.age > 13 && x.age <= 18)).ToList())
            {
                Console.WriteLine("Name: " + person.name + " (Age)" + person.age);
            }*/

            double AverageAge = listPerson.Average(x => x.age);
            Console.WriteLine("AverageAge: " + AverageAge);
        }

        public static void RetrivePersonName(List<Person> listPerson)
        {
            /*foreach (Person person in listPerson.FindAll(x => (x.age > 13 && x.age <= 18)).ToList())
            {
                Console.WriteLine("Name: " + person.name + " (Age)" + person.age);
            }*/

            if (listPerson.Any(x => (x.name == "Arun")))
            {
                Console.WriteLine("Present");
            }

            /*double AverageAge = listPerson.Average(x => x.age);
            Console.WriteLine("AverageAge: " + AverageAge);*/
        }

        public static void SkipPersonAgeIsLessThanSixty(List<Person> listPerson)
        {
            foreach (Person person in listPerson.SkipWhile(x => (x.age <= 60)).Take(2).ToList())
            {
                Console.WriteLine("Name: " + person.name + " (Age)" + person.age);
            }
        }

        public static void RemoveName(List<Person> listPerson)
        {           
            var index = listPerson.FindIndex(x => x.name == "Yogi");
            if (index >= 0) listPerson.RemoveAt(index);
            Console.WriteLine("Removed!");
            /*{
                Console.WriteLine("Present");
            }*/
        }
    }
}
