using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mike", 20);
            person.GetNameAndAge();
            
            Teacher teacher = new Teacher("Wisnu", 50, "196969", "Komdat");
            teacher.GetNameAndAge();
            
			Student student = new Student("Umam", 19, "19.11.2888", "mufti.2906@students.amikom.ac.id");
            student.GetNameAndAge();
            Console.ReadKey();
        }
    }
}
