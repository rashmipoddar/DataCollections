using System;
using System.Collections.Generic;
using System.Linq;

namespace DataCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a collection using List<T> type
            // It stores sequences of elements and we specify the element type between the angle
            // Initialize a list of ints with a length of 3
            List<int> numbers = new List<int>(3);

            // Add elements to the list
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            // The list can grow or shrink enabling us to add or remove elements irrespective of the list size declared initially
            numbers.Add(4);
            numbers.Add(5);

            Console.WriteLine(numbers.Count); // 5
            Console.WriteLine(numbers.Capacity); // 6

            // Adding an existing collection to a list
            string[] animals = { "Cow", "Camel", "Elephant" };
            List<string> animalsList = new List<string>(animals);

            // Printing all the elements of a list
            foreach(string animal in animalsList)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine("---------");

            // Adding an existing collection to a list using AddRange
            List<string> animalsListUsingRange = new List<string>();
            animalsListUsingRange.AddRange(animals);

            // Print all elements of a list using foreach LINQ method
            animalsListUsingRange.ForEach(animal => Console.WriteLine(animal));
            Console.WriteLine("---------");

            string[] writers = new string[] { "Danielle Steele", "John Grisham" };
            List<string> authors = new List<string>();
            authors.Add("Jeffrey Archer");
            authors.AddRange(writers);

            authors.ForEach(author => Console.WriteLine(author));
            Console.WriteLine("---------");

            // Insert at specific position
            authors.Insert(1, "Ruskin Bond");
            authors.ForEach(author => Console.WriteLine(author));
            Console.WriteLine("---------");
            string[] newAuthors = { "Amish", "Glendy Vanderah" };
            authors.InsertRange(0, newAuthors);
            authors.ForEach(author => Console.WriteLine(author));
            Console.WriteLine("---------");

            // Remove from list
            authors.Remove("Jeffrey Archer");
            authors.RemoveAt(2);
            authors.ForEach(author => Console.WriteLine(author));
            Console.WriteLine("---------");

            authors.RemoveRange(2, 2);
            authors.ForEach(author => Console.WriteLine(author));
            Console.WriteLine("---------");

            authors.Clear();
            Console.WriteLine(authors.Count); // 0

            authors.AddRange(writers);
            authors.InsertRange(0, newAuthors);
            authors.Add("Amish");
            authors.Insert(2, "Amish");
            authors.ForEach(author => Console.WriteLine(author));
            Console.WriteLine("---------");


            Console.WriteLine(authors.IndexOf("Amish")); // 0
            Console.WriteLine(authors.LastIndexOf("Amish")); // 5
            // We can provide an optional index from which index of starts searching.
            Console.WriteLine(authors.IndexOf("Amish", 2)); // 2
            Console.WriteLine("---------");

            Console.WriteLine("Original authors List");
            authors.ForEach(author => Console.WriteLine(author));
            Console.WriteLine("---------");

            authors.Sort();
            Console.WriteLine("Sorted authors");
            authors.ForEach(author => Console.WriteLine(author));
            Console.WriteLine("---------");

            Console.WriteLine("Original animals");
            animalsList.ForEach(animal => Console.WriteLine(animal));
            Console.WriteLine("---------");

            // OrderBy does not modify the original list
            List<string> sortedAnimalsList = new List<String>();
            sortedAnimalsList = animalsList.OrderBy(p => p.Substring(0)).ToList();
            Console.WriteLine("Sorted animals in ascending order");
            sortedAnimalsList.ForEach(animal => Console.WriteLine(animal));
            Console.WriteLine("---------");

            List<string> sortedAnimals = new List<String>();
            var sortedAnimalsListAsc = from y in animalsList
                                       orderby y ascending
                                       select y;
            Console.WriteLine("Sorted animals in ascending order");
            Console.WriteLine(sortedAnimalsListAsc.GetType());
            sortedAnimals = sortedAnimalsListAsc.ToList();
            Console.WriteLine(sortedAnimals.GetType());
            sortedAnimals.ForEach(animal => Console.WriteLine(animal));
            Console.WriteLine("---------");

            List<string> sortedAnimalsListDesc = new List<String>();
            sortedAnimalsListDesc = animalsList.OrderByDescending(p => p.Substring(0)).ToList();
            Console.WriteLine("Sorted animals in descending order");
            Console.WriteLine(sortedAnimalsListDesc.GetType());
            sortedAnimalsListDesc.ForEach(animal => Console.WriteLine(animal));
            Console.WriteLine("---------");

            int bs = animalsList.BinarySearch("Camel");
            Console.WriteLine(bs); // 1
        }
    }
}
