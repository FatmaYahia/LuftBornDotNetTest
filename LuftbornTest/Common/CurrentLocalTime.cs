using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class CurrentLocalTime
    {
        public static DateTime GetCurrentTime(string timeZone = "Egypt Standard Time")
        {
            return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, timeZone);
        }
    }
}
