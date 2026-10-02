using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.ConsoleApp
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TimeFormat.FormatDuration(60));
        }
    }
    public static class TimeFormat
    {
        public static string FormatDuration(int seconds)
        {
            if (seconds == 0) return "now";
            var timeUnits = new Dictionary<string, int>
            {
                { "year", 31536000},
                { "day", 86400},
                { "hour", 3600},
                { "minute", 60},
                { "second", 1 }
            };
            var parts = new List<string>();
            foreach (var unit in timeUnits)
            {
                var unitValue = seconds / unit.Value;
                if (unitValue > 0)
                {
                    parts.Add($"{unitValue} {unit.Key}{(unitValue > 1 ? "s" : "")}");
                    seconds -= unitValue * unit.Value;
                }
            }
            return string.Join(", ", parts.Take(parts.Count - 1)) + (parts.Count > 1 ? " and " : "") + parts.Last();
        }
    }
}
