using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier;

public static class DateModifier
{
    public static int GetDiference(string start, string end)
    {
        DateTime startDay = DateTime.Parse(start);
        DateTime endDay = DateTime.Parse(end);
       
        TimeSpan difference = startDay - endDay;
        return Math.Abs(difference.Days);
    }

}
