namespace Practice1
{
    class City: IMessageWritter
    {
        private string name;
        private PoliceStation policeStation;
        public List<Taxi> CityTaxis { get; private set; }

        public City(string name, PoliceStation policeStation)
        {
            this.name = name;
            this.policeStation = policeStation;
            CityTaxis = new List<Taxi>();
        }

        public override string ToString()
        {
            return $"City {GetCityName()}";
        }

        public string GetCityName()
        {
            return name;
        }

        public void RegisterNewTaxiLicense(string plate)
        {
            CityTaxis.Add(new Taxi(plate));
        }

        public void RemoveTaxiLicense(string plate)
        {
            taxi = GetTaxiInstance(plate);
            CityTaxis.Remove(taxi);
        }

        public Taxi GetTaxiInstance(string plate)
        {
            foreach (Taxi taxi in CityTaxis)
            {
                if (taxi.GetPlate() == plate)
                {
                    return taxi;
                }
            }
        }

        public string WriteMessage(string message)
        {
            return $"{this}: {message}";   
        }

    }
}

