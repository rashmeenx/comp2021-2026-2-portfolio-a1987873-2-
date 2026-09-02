using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Person fred = new Person("Fred", "Smith", 21);
        Person person2 = new Person("Fred", "Smith", 32);
        Person person3 = new Person("Fred", "Smith", 21);
        Person person4 = new Person("Sarah", "Jones", 15);
        Person person5 = new Person("James", "Taylor", 45);
        Person person6 = new Person("Alice", "White", 26);
        Person person7 = new Person("David", "Lee", 19);
        Person person8 = new Person("Mia", "Martin", 12);
        Person person9 = new Person("Tom", "Clark", 60);
        Person person10 = new Person("Lucy", "Walker", 23);

        List<Person> people = new List<Person>();

        people.Add(fred);
        people.Add(person2);
        people.Add(person3);
        people.Add(person4);
        people.Add(person5);
        people.Add(person6);
        people.Add(person7);
        people.Add(person8);
        people.Add(person9);
        people.Add(person10);

        // Convert List to LinkedList
        LinkedList<Person> linkedPeople = ToLinkedList(people);

        Console.WriteLine("Before sorting:");
        Console.WriteLine(PrintPeople(linkedPeople));

        // Sort
        linkedPeople = SortPeople(linkedPeople);

        Console.WriteLine("After sorting:");
        Console.WriteLine(PrintPeople(linkedPeople));

        // Reflection test
        fred.Age = 25;

        Console.WriteLine("After changing Fred's age:");
        Console.WriteLine(PrintPeople(linkedPeople));
    }



    public static LinkedList<Person> ToLinkedList(List<Person> people)
    {
        LinkedList<Person> linkedPeople = new LinkedList<Person>();

        foreach (Person person in people)
        {
            linkedPeople.AddLast(person);
        }

        return linkedPeople;
    }

    public static string PrintPeople(LinkedList<Person> people)
    {
        string result = "";

        foreach (Person person in people)
        {
            result += person.FullName + ", Age: " + person.Age + "\n";
        }

        return result;
    }

    public static LinkedList<Person> SortPeople(LinkedList<Person> people)
    {
        LinkedList<Person> sortedPeople = new LinkedList<Person>();

        int amountOfPeople = people.Count;

        for (int i = 0; i<amountOfPeople; i++)
        {
            LinkedListNode<Person>? current = people.First;

            Person? youngestPerson = null;
            double youngestAge = double.MaxValue;

            while (current != null)
            {
                if (current.Value.Age < youngestAge)
                {
                    youngestAge = current.Value.Age;
                    youngestPerson = current.Value;
                }

                current = current.Next;
            }

            if (youngestPerson != null)
            {
                sortedPeople.AddLast(youngestPerson);
                people.Remove(youngestPerson);
            }
        }
        return sortedPeople;


    }
    



}
