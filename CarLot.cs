using System;
using System.Collections.Generic;

/*Creatd custom class for carLot and characteristics */

namespace CarLot{
    public class CarLot{
        public List<Car> Inventory{get; set;} = new List<Car>();

        public string Owner{get; set;}
        public string Address {get; set;}

    }
}