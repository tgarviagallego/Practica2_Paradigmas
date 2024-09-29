namespace Practice1
{
    class City: IMessageWritter
    {
        private string name;
        public List<Taxi> CityTaxis { get; private set; }

        public City(string name)
        {
            this.name = name;
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
            Taxi taxi = GetTaxiInstance(plate);
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
            return null;
        }

        public string WriteMessage(string message)
        {
            return $"{this}: {message}";   
        }

    }
}

