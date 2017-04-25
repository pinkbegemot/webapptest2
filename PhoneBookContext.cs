using System.Data.Entity;

namespace PhoneBookTestApp {
    internal class PhoneBookContext : DbContext {
        public PhoneBookContext()
            : base("PhonebookConn") {
            Database.SetInitializer(new CreateDatabaseIfNotExists<PhoneBookContext>());
            Database.SetInitializer(new DropCreateDatabaseAlways<PhoneBookContext>());
        }

        public virtual DbSet<Person> Phonebook { get; set; }
    }
}