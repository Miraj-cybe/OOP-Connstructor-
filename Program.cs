using System;
namespace practice
{
    class Car
    {
string CarName ;
int makeYear;
//Default Constructor
public Car()
        {
           CarName = "Toyota";
              makeYear = 2020; 
        }
//paramterized Constructor
public Car( string a ,int x)
        {
            CarName =a;
            makeYear =x;
        }
public void displayInfo()
        {
            Console.WriteLine("Car Details: " + CarName + "." + " Make Year:  " + makeYear);
        }
        static void Main(string[] args)
        {
            Car carDetails = new Car();
          carDetails.displayInfo();
         
          Car Cardetails =new Car("Honda",2022);
          Cardetails.displayInfo();
        }
    }
}