namespace Deconstruct.Models
{
    public class Person
    {
        public Person()
        {
            
        }
        //Constructor
        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        //Desconstrutor
        public void Deconstruct(out string name, out string lastName)
        {
            name = Name;
            lastName = LastName;
        }
        public string Name { get; set; }
        public string LastName { get; set; }

  
    }
}