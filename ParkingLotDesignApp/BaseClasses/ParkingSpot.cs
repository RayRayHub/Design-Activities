namespace ParkingLotDesignApp.BaseClasses
{
    /// <summary>
    /// This is an abstract class meaning we will not be able to instantiate this class directly.
    /// Instead we will want to use one of the dervied classes to create this object.
    /// </summary>
    public abstract class ParkingSpot 
    {
        //Properties
        public Guid Id { get; set; }
        public bool IsReserved { get; set; }

        //Constructors
        public ParkingSpot(bool isReserved = false)
        {
            Id = Guid.NewGuid();
            this.IsReserved = isReserved;
        }
    }
}