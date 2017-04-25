using System;

///* TODO: create person objects and put them in the PhoneBook and database
//* John Smith, (248) 123-4567, 1234 Sand Hill Dr, Royal Oak, MI
//* Cynthia Smith, (824) 128-8758, 875 Main St, Ann Arbor, MI
//*/
//// TODO: print the phone book out to System.out
//// TODO: find Cynthia Smith and print out just her entry
//// TODO: insert the new person objects into the database

namespace PhoneBookTestApp {
    internal class Program {
        private static void Main(string[] args) {
            try{
                Console.WriteLine("Creating new DB. Wait...");
                var book = new PhoneBook();
                book.Initialize();
                Console.WriteLine("Done initializing. Adding 2 default persons.");
                var p = new Person {
                    Name = "John Smith",
                    PhoneNumber = "(248) 123-4567",
                    Address = "1234 Sand Hill Dr, Royal Oak, MI"
                };
                var c = new Person {
                    Name = "Cynthia Smith",
                    PhoneNumber = "(824) 128-8758",
                    Address = "875 Main St, Ann Arbor, MI"
                };
                book.AddPerson(p);
                book.AddPerson(c);

                Person[] pers = book.FindAll();

                foreach (Person s in pers){
                    Console.WriteLine(s.Name + ", " + s.Address + ", " + s.PhoneNumber);
                }
                Console.WriteLine("Total count: " + pers.Length);
                Console.WriteLine("Searching for a given person.");

                Person n = book.FindPerson("Cynthia Smith");
                Console.WriteLine("Found: " + n.Name + " " + n.Address + " " + n.PhoneNumber);
                Console.WriteLine("Adding new person: ");
                Console.WriteLine("Enter the name, phone, address, separated by comma : ");

                string entry = Console.ReadLine();
                if (entry != null){
                    string[] entries = entry.Split(',');

                    book.AddPerson(new Person {Name = entries[0], PhoneNumber = entries[1], Address = entries[2]});
                }

                Console.WriteLine("New entry added!");
                Console.WriteLine();
                pers = book.FindAll();

                foreach (Person s in pers){
                    Console.WriteLine(s.Name + ", " + s.Address + ", " + s.PhoneNumber);
                }
                Console.WriteLine("New count: " + pers.Length);
                Console.ReadLine();
            }
            catch (Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}