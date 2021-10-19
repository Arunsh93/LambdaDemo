using System;
using System.Collections.Generic;

namespace LambdaExpressionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPerson = new List<Person>();
            Person.AddMembers(listPerson);
            Person.RetrivePersonAgeIsLessThanSixty(listPerson);

            Console.WriteLine("===================");

            Person.RetriveAllPersonAgeIsBetween13to18(listPerson);

            Console.WriteLine("===================");

            Person.RetriveAllPersonAverageAge(listPerson);

            Console.WriteLine("===================");

            Person.RetrivePersonName(listPerson);

            Console.WriteLine("===================");

            Person.SkipPersonAgeIsLessThanSixty(listPerson);

            Console.WriteLine("===================");

            Person.RemoveName(listPerson);

        }
    }
}
