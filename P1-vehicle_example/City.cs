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

        public string RemoveTaxiLicense(string plate)
        {
            bool foundTaxi = false;
            for (int i=0; i<CityTaxis.Count; i++)
            {
                if (CityTaxis[i].GetPlate() == plate)
                {
                    CityTaxis.Remove(CityTaxis[i]);
                    foundTaxi = true;
                }
            }
            if (foundTaxi)
            {
                return WriteMessage($"removed license of taxi with plate {plate}.");
            }
            else
            {
                return WriteMessage($"no taxi found with plate {plate}");
            }
        }

        public string WriteMessage(string message)
        {
            return $"{this}: {message}";   
        }

    }
}

