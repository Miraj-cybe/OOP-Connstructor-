using System;
namespace practice
{
    class Person
    {
        public string name = "Miraj Mondol";
        private int age;

    
    public void setage(int personAge)  //to read private age variable
        {
            age = personAge;
        }
//For Readable
 public int Getage()
        {
        return age;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
         Person person1 = new Person();
         person1.setage(22);
         Console.WriteLine($"Name: {person1.name} , Age: {person1.Getage()}");

        }
    }
}