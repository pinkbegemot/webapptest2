using System.ComponentModel.DataAnnotations;

namespace PhoneBookTestApp {
    public class Person {
        [Key]
        public string Name { get; set; }

        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}