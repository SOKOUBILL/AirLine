

namespace AirLine.BO.Entities
{
    public class Flight : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public TimeSpan ScheduledDepartureTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public TimeSpan ScheduledArrivatTime { get; set; }
        
    }
}
