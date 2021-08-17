namespace Codecool.CarRace.Vehicle.Kind

{
    /// <summary>
    /// This is the Car class
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Prepare for the next hour: take the special events into consideration (broken truck etc)
        /// Implemented per subclass
        /// </summary>
        /// <param name="race">instance of the currently ongoing race</param>
        public override void PrepareForLap(Race race)
        {

        }
    }
}
