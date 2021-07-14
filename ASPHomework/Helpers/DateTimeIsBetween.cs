using System;

namespace ASPHomework.Helpers
{
    public static class DateTimeIsBetween
    {
        public static bool IsBetween(this DateTime input, DateTime date1, DateTime date2)
        {
            return (input > date1 && input < date2);
        }
    }
}

