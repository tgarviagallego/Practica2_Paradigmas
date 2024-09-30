namespace Practice1
{
    class PoliceStation: IMessageWritter
    {
        public List<PoliceCar> StationPoliceCars { get; private set; }
        private string id;
        private City city;

        public PoliceStation(string id, City city)
        {
            StationPoliceCars = new List<PoliceCar>();
            this.id = id;
            this.city = city;
        }

        public override string ToString()
        {
            return $"Police Station {GetId()}";
        }

        public string GetId()
        {
            return id;
        }

        public City GetCity()
        {
            return city;
        }

        public void SendAlarm(string plate)
        {
            Console.WriteLine(WriteMessage($"sent alarm to chase car with plate {plate}."));
            foreach (PoliceCar policeCar in StationPoliceCars)
            {
                if (policeCar.IsPatrolling())
                {
                    policeCar.ChaseCar(plate);
                }
            }
        }

        public void RegisterNewPoliceCar(string plate, bool hasSpeedRadar)
        {
            StationPoliceCars.Add(new PoliceCar(plate, this, hasSpeedRadar));
        }

        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }
    }
}
