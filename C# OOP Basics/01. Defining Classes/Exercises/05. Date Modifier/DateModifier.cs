using System;

class DateModifier
{
    public int DayDifference { get; }

    public DateModifier(DateTime firstDate, DateTime secondDate)
    {
        DayDifference = Math.Abs((firstDate - secondDate).Days);
    }
}