using System.Linq;

namespace PhoneBookTestApp {
    public class PhoneBook : IPhoneBook {
        public void AddPerson(Person person) {
            using (var context = new PhoneBookContext()){
                context.Phonebook.Add(person);
                context.SaveChanges();
            }
        }

        public Person FindPerson(string x) {
            using (var context = new PhoneBookContext()){
                Person row = context.Phonebook.FirstOrDefault(p => p.Name == x);
                return row;
            }
        }


        public void Initialize() {
            AddPerson(new Person {
                Name = "Chris Johnson",
                PhoneNumber = "(321) 231-7876",
                Address = "452 Freeman Drive, Algonac, MI"
            });
            AddPerson(new Person {
                Name = "Dave Williams",
                PhoneNumber = "(231) 502-1236",
                Address = "285 Huron St, Port Austin, MI"
            });
        }

        public Person[] FindAll() {
            using (var db = new PhoneBookContext()){
                return db.Phonebook.ToArray();
            }
        }
    }
}