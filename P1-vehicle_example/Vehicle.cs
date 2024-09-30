﻿namespace Practice1
{
    abstract class Vehicle : VehicleWithoutPlate
    {
        private string plate;

        public Vehicle(string typeOfVehicle, string plate): base(typeOfVehicle)
        {
            this.plate = plate;
        }

        //Override ToString() method with class information
        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} with plate {GetPlate()}";
        }

        public string GetPlate()
        {
            return plate;
        }
    }
}