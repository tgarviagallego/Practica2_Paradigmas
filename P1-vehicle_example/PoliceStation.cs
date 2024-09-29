namespace Practice1
{
    class PoliceStation: IMessageWritter
    {
        public List<PoliceCar> StationPoliceCars { get; private set; }
        private bool alert;
        private string chasedCarPlate;
        private string id;
        private City city;

        public PoliceStation(string id, City city)
        {
            StationPoliceCars = new List<PoliceCar>();
            alert = false;
            chasedCarPlate = "";
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

        public void SetChasedCarPlate(string plate)
        {
            chasedCarPlate = plate;
        }

        public void SendAlarm(string plate)
        {
            SetChasedCarPlate(plate);
            foreach (PoliceCar policeCar in StationPoliceCars)
            {
                if (policeCar.IsPatrolling())
                {
                    policeCar.IsChasingCar(GetCity().GetTaxiInstance(plate));
                }
            }
            alert = true;
        }

        public void DeactivateAlarm()
        {
            alert = false;
        }

        public void RegisterNewPoliceCar(string plate)
        {
            StationPoliceCars.Add(new PoliceCar(plate));
        }

        private List<Taxi> taxiList;

        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }
    }
}
