namespace Practice1
{
    class PoliceCar : Vehicle
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car"; 
        private bool isPatrolling;
        private SpeedRadar? speedRadar;
        private bool isChasingCar;
        private PoliceStation policeStation;

        public PoliceCar(string plate, PoliceStation policeStation, bool hasSpeedRadar) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;
            if (hasSpeedRadar)
            {
                speedRadar = new SpeedRadar();
            }
            isChasingCar = false;
            this.policeStation = policeStation;
        }

        public void UseRadar(Vehicle vehicle)
        {
            if (isPatrolling)
            {
                if (speedRadar != null)
                {
                    speedRadar.TriggerRadar(vehicle);
                    string meassurement = speedRadar.GetLastReading();
                    Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement}"));
                    if (meassurement.EndsWith("Catched above legal speed."))
                    {
                        policeStation.SendAlarm(speedRadar.GetPlateFromRadar());
                        isChasingCar = true;
                    }
                }
                else
                {
                    Console.WriteLine(WriteMessage($"has no radar."));
                }
            }
            else
            {
                Console.WriteLine(WriteMessage($"has no active radar."));
            }
        }

        public void ChaseCar(string plate)
        {
            if (speedRadar != null)
            {
                speedRadar.SetPlateFromRadar(plate);
                isChasingCar = true;
                Console.WriteLine(WriteMessage($"started chasing car with plate {plate}."));
            }
            else
            {
                Console.WriteLine(WriteMessage($"has no radar to chase car with plate {plate}."));
            }
        }

        public void StopChasingCar()
        {
            if (isChasingCar)
            {
                if (speedRadar != null)
                {
                    isChasingCar = false;
                    Console.WriteLine(WriteMessage($"stopped chasing car with plate {speedRadar.GetPlateFromRadar()}."));
                }
                else
                {
                    Console.WriteLine(WriteMessage($"has no radar."));
                }
            }
            else
            {
                Console.WriteLine(WriteMessage($"is not chasing car."));
            }
        }

        public bool IsPatrolling()
        {
            return isPatrolling;
        }

        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }

        public void PrintRadarHistory()
        {
            if (speedRadar != null)
            {
                Console.WriteLine(WriteMessage("Report radar speed history:"));
                foreach (float speed in speedRadar.SpeedHistory)
                {
                    Console.WriteLine(speed);
                }
            }
            else
            {
                Console.WriteLine(WriteMessage($"has no radar."));
            }
        }
    }
}