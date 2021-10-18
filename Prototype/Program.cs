using System;

namespace Prototype
{
    public class Person
    {
        public  int Age;
        public DateTime BirthDate;
        public string Name;
        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();    
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Age = 42;
            p1.BirthDate = Convert.ToDateTime("1997-01-01");
            p1.Name = "Jack";
            Person p2 = p1.ShallowCopy();

          
        }
    }
}
