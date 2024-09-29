namespace Practice1
{
    internal class Program
    { 
        static void Main()
        {
            City city = new City("Madrid");
            Console.WriteLine(city.WriteMessage("Created"));
            PoliceStation policeStation = new PoliceStation("1", city);
            Console.WriteLine(policeStation.WriteMessage("Created"));
            city.RegisterNewTaxiLicense("0001 AAA");
            city.RegisterNewTaxiLicense("0002 BBB");

            policeStation.RegisterNewPoliceCar("0001 CNP");
            policeStation.RegisterNewPoliceCar("0002 CNP");

           
            Console.WriteLine(city.CityTaxis[0].WriteMessage("Created"));
            Console.WriteLine(city.CityTaxis[1].WriteMessage("Created"));
            Console.WriteLine(policeStation.StationPoliceCars[0].WriteMessage("Created"));
            Console.WriteLine(policeStation.StationPoliceCars[1].WriteMessage("Created"));

            policeStation.StationPoliceCars[0].StartPatrolling();
            policeStation.StationPoliceCars[0].UseRadar(city.CityTaxis[0]);

            city.CityTaxis[1].StartRide();
            policeStation.StationPoliceCars[1].UseRadar(city.CityTaxis[1]);
            policeStation.StationPoliceCars[1].StartPatrolling();
            policeStation.StationPoliceCars[1].UseRadar(city.CityTaxis[1]);
            city.CityTaxis[1].StopRide();
            policeStation.StationPoliceCars[1].EndPatrolling();

            city.CityTaxis[0].StartRide();
            city.CityTaxis[0].StartRide();
            policeStation.StationPoliceCars[0].StartPatrolling();
            policeStation.StationPoliceCars[0].UseRadar(city.CityTaxis[0]);
            city.CityTaxis[0].StopRide();
            city.CityTaxis[0].StopRide();
            policeStation.StationPoliceCars[0].EndPatrolling();

            policeStation.StationPoliceCars[0].PrintRadarHistory();
            policeStation.StationPoliceCars[1].PrintRadarHistory();

        }
    }
}
    

