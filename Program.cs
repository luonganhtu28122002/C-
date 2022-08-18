using System;
namespace lap3
{
    class Program
    {
        public static void Main()
        {
            //declare a Car object reference named myCar
            Car myCar;
            //Create a Car object, and assign its address to myCar
            System.Console.WriteLine("Creating a Car object and assingning " + "its memory location to myCar");
            myCar = new Car();

            //assign values to the Car onject fields using myCar
            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.color = "black";
            myCar.yearBuilt = 1995;

            //display the field values using mayCar
            System.Console.WriteLine("myCar details:");
            System.Console.WriteLine("myCar.make = " + myCar.make);
            System.Console.WriteLine("myCar.model = " + myCar.model);
            System.Console.WriteLine("myCar.color = " + myCar.color);
            System.Console.WriteLine("myCar.yearBuilt = " + myCar.yearBuilt);

            //call the method using myCar
            myCar.Start();
            myCar.Start();

            //declare another Car object reference and
            //create another Car object
            System.Console.WriteLine("Creating another Car object and" + "assigning its memory location to redPorsche");
            Car redProsche = new Car();
            redProsche.make = "Porsche";
            redProsche.model = "Boxster";
            redProsche.color = "red";
            redProsche.yearBuilt = 2000;
            System.Console.WriteLine("redPorsche is a " + redProsche.model);
            //change the object referenced by the myCar object
            //reference to the object referenced by redPorsche
            System.Console.WriteLine("Assigning redPorsche to myCar");
            myCar = redProsche;
            System.Console.WriteLine("myCar details:");
            System.Console.WriteLine("myCar.make = " + myCar.make);
            System.Console.WriteLine("myCar.model = " + myCar.model);
            System.Console.WriteLine("myCar.color = " + myCar.color);
            System.Console.WriteLine("myCar.yearBuilt = " + myCar.yearBuilt);
            //assign null to myCar (myCar will no longer reference an object)
            myCar = null;
            Console.ReadLine();
        }
    }
}

