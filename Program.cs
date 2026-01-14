using System;
namespace practice
{
    class Person
    {       private string name;
        private int age;

        public string Name
        {
            get{return name; }

            set
            {name = value;}

             }
public int Age
        {
            get{ return age;}
set{ age = value;}
        }

        }

    
   /*  public void setage(int personAge)  //to write private age variable
        {
            age = personAge;
        }
            //For Readable
 public int Getage()
        {
        return age;
        }
    */

    
    class Program
    {
        static void Main(string[] args)
        {
         Person person1 = new Person();
         person1.Name ="Miraj Mondol";
         person1.Age = 22;
         Console.WriteLine($"Name: {person1.Name} , Age: {person1.Age}");

        }
    }
}
