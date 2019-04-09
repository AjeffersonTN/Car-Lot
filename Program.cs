using System;
using System.Collections.Generic;

namespace CarLot {

    class Program {
        static void Main (string[] args){
/*Define a Dictionary to represent a car using the format in the Car class

* Make
* Model
* Year
* Price
 */
    Car TheFord = new Car {
        Make = "Ford",
        Model = "Mustang",
        Year = 2012,
        Price = 152005.09
    };
    Car TheChevy = new Car {
        Make = "Chevy",
        Model = "Suburban",
        Year = 2019,
        Price = 45000.76
    };
    Car TheHonda = new Car {
        Make = "Honda",
        Model = "Civic",
        Year = 2014,
        Price = 18054.99
    };

    /*created carLot in ordr to assign cars from inventory */

    CarLot antoniosNewCars = new CarLot(){
        Owner = "Antonio Jefferson",
        Address = "123 Main St."
    };

    antoniosNewCars.Inventory.Add(TheChevy);
    antoniosNewCars.Inventory.Add(TheHonda);
    antoniosNewCars.Inventory.Add(TheFord);

    foreach (Car car in antoniosNewCars.Inventory)
    {
        Console.WriteLine($@"
Make:{car.Make}
Model:{car.Model}
Year:{car.Year}
Price:{car.Price}");

    }
        }
    }
}
/** Create a car lot list.
* Add each car to the car lot.
* Iterate the car lot list and output all the details of each car*/