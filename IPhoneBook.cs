namespace PhoneBookTestApp {
    public interface IPhoneBook {
        Person FindPerson(string firstName);
        void AddPerson(Person newPerson);
    }
}