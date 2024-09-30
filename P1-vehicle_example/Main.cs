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
            city.RegisterNewTaxiLicense("0003 CCC");
            Console.WriteLine(city.CityTaxis[0].WriteMessage("Created"));
            Console.WriteLine(city.CityTaxis[1].WriteMessage("Created"));
            Console.WriteLine(city.CityTaxis[2].WriteMessage("Created"));

            policeStation.RegisterNewPoliceCar("0001 CNP", true);
            policeStation.RegisterNewPoliceCar("0002 CNP", true);
            policeStation.RegisterNewPoliceCar("0003 CNP", false);
            Console.WriteLine(policeStation.StationPoliceCars[0].WriteMessage("Created"));
            Console.WriteLine(policeStation.StationPoliceCars[1].WriteMessage("Created"));
            Console.WriteLine(policeStation.StationPoliceCars[2].WriteMessage("Created"));

            policeStation.StationPoliceCars[2].StartPatrolling();
            policeStation.StationPoliceCars[2].UseRadar(city.CityTaxis[0]);

            policeStation.StationPoliceCars[0].StartPatrolling();
            policeStation.StationPoliceCars[1].StartPatrolling();
            city.CityTaxis[0].StartRide();
            policeStation.StationPoliceCars[0].UseRadar(city.CityTaxis[0]);

            Console.WriteLine(city.RemoveTaxiLicense("0001 AAA"));

            policeStation.StationPoliceCars[0].EndPatrolling();
            policeStation.StationPoliceCars[1].EndPatrolling();
            policeStation.StationPoliceCars[2].EndPatrolling();

            policeStation.StationPoliceCars[0].PrintRadarHistory();
            policeStation.StationPoliceCars[1].PrintRadarHistory();
            policeStation.StationPoliceCars[2].PrintRadarHistory();

        }
    }
}
    

