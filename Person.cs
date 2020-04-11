using System;
namespace Inheritance
{
    public class Person
    {
        public string Name {get; set;}
        public int Age{get;set;}
        public Person(string Name, int Age){
            this.Name=Name;
            this.Age=Age;
        }
        public void GetNameAndAge()
        {
            Console.WriteLine("The Person has name:{0} and Age {1}", Name, Age);
        }
    }
}
