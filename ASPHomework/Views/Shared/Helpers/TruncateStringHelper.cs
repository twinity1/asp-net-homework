using System;

namespace ASPHomework.Views.Shared.Helpers
{
    public static class TruncateStringHelper
    {
        public static String Truncate(this string str, int maxSize, string truncateAppend = "...")
        {
            var result = str;

            if (result.Length >= maxSize)
            {
                result = result.Substring(0, maxSize - truncateAppend.Length) + truncateAppend;
            }

            return result;
        }
    }
}