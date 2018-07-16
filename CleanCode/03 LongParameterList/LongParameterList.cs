
using System;
using System.Collections.Generic;

namespace CleanCode.LongParameterList
{
    public class LongParameterList
    {
        public IEnumerable<Reservation> GetReservations(
           DateRange dateRange,
           UserLocation UserLocation, Customer customer)
        {
            if (dateRange.From >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (dateRange.To <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public IEnumerable<Reservation> GetUpcomingReservations(
            DateRange dateRange,
            UserLocation UserLocation)
        {
            if (dateRange.From >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (dateRange.To <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        private static Tuple<DateTime, DateTime> GetReservationDateRange(DateRange dateRange, ReservationDefinition sd)
        {
            if (dateRange.From >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (dateRange.To <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public void CreateReservation(DateRange dateRange, UserLocation UserLocation)
        {
            if (dateRange.From >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (dateRange.To <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }
    }

    public class Customer
    {
        public int? customerId;
    }

    public class UserLocation
    {
        public User user;
        public int locationId;
        public LocationType locationType;
    }

    public class DateRange
    {
        public DateTime From;
        public DateTime To;
    }

    internal class ReservationDefinition
    {
    }

    public class LocationType
    {
    }

    public class User
    {
        public object Id { get; set; }
    }

    public class Reservation
    {
    }

    
}
