namespace Codecool.CarRace.Vehicle
{
    /// <summary>
    /// This is the Vehicle class
    /// </summary>
    public abstract class Vehicle
    {
        protected Vehicle()
        {
            Name = "Vehice"; //TODO: set name according to specification
            NormalSpeed = 100; //TODO: set normal speed according to specification
        }

        /// <summary>
        /// The speed this vehicle usually travels with.
        /// </summary>
        protected readonly int NormalSpeed;

        /// <summary>
        /// The name of this vehicle.
        /// </summary>
        protected readonly string Name;

        /// <summary>
        /// The speed of this vehicle for the given hour.
        /// <para>
        /// Will be set in the implementing classes.
        /// </para>
        /// </summary>
        protected int ActualSpeed;

        /// <summary>
        /// A variable accumulating the total of distance this vehicle has
        /// travelled.
        /// </summary>
        protected int DistanceTravelled;

        /// <summary>
        /// Prepare for the next hour: take the special events into consideration (broken truck etc)
        /// Implemented per subclass
        /// </summary>
        /// <param name="race">instance of the currently ongoing race</param>
        public abstract void PrepareForLap(Race race);

        /// <summary>
        /// Simulate the vehicle for one hour. Only updates the travelled distance,
        /// actual speed should be updated before calling this method
        /// </summary>
        public void MoveForAnHour()
        {
            DistanceTravelled += ActualSpeed;
        }

    }
}