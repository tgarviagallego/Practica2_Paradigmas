namespace Practice1
{
    abstract class VehicleWithoutPlate: IMessageWritter
    {
        private string typeOfVehicle;
        private float speed;

        public VehicleWithoutPlate(string typeOfVehicle)
        {
            this.typeOfVehicle = typeOfVehicle;
            speed = 0f;
        }

        public override string ToString()
        {
            return $"{GetTypeOfVehicle()}";
        }

        public string GetTypeOfVehicle()
        {
            return typeOfVehicle;
        }

        public float GetSpeed()
        {
            return speed;
        }

        public void SetSpeed(float speed)
        {
            this.speed = speed;
        }

        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }
    }
}
