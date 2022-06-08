// See https://aka.ms/new-console-template for more information
//declare a Car object reference named myCar
using lab3;

Car myCar;
System.Console.WriteLine("Creating a car object and assigning" +
    "its memory location to myCar");
myCar = new Car();
//assign values to the Car object fields fields using myCar
myCar.make = "Toyota";
myCar.model = "MR2";
myCar.color = "black";
myCar.yearBuilt = 1995;
//display the fields values using myCar
System.Console.WriteLine("MyCar details:");
System.Console.WriteLine("MyCar make:"+myCar.make);
System.Console.WriteLine("MyCar models:"+myCar.model);
System.Console.WriteLine("MyCar color:"+myCar.color);
System.Console.WriteLine("MyCar yearbuilt:"+myCar.yearBuilt);
//call the methods using myCar
myCar.Start();
myCar.Stop();
//declare another Car object reference and 
// create another Car object
 System.Console.WriteLine("Creating another Car object and" + "assigning its memory location to redPorsche");
Car redPorsche=new Car();
redPorsche.make = "Porsche";
redPorsche.model = "Boxster";
redPorsche.color = "red";
redPorsche.yearBuilt = 2000;
System.Console.WriteLine("redPorsche is a " + redPorsche.model);
//change the object referenced by the myCar object //reference to the object referenced by redPorshe
System.Console.WriteLine("Assing redPorsche to myCar");
myCar = redPorsche;
System.Console.WriteLine("myCar details:");
System.Console.WriteLine("myCar.make = " + myCar.make);
System.Console.WriteLine("myCar.model = " + myCar.model);
System.Console.WriteLine("myCar.color = " + myCar.color);
System.Console.WriteLine("myCar.yearBuilt = " + myCar.yearBuilt);
// assign null to myCar (myCar will no longer reference 
//an object)
myCar = null;
Console.ReadLine();





