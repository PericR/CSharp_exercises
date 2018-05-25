using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9WorkDays
{
    public static class WorkDays
    {
        private static DateTime[] holidays = new DateTime[]
        {
            new DateTime(1,2,20),
            new DateTime(1, 6, 7),
            new DateTime(1, 12, 24),
            new DateTime(1,12,25),
        };

        private static DateTime[] workingSaturdays = new DateTime[]
        {
            new DateTime(1,3,21),
            new DateTime(1,4,12),
            new DateTime(1,5,14),
            new DateTime(1,2,24)
        };

        public static int CountWorkDays(DateTime end)
        {
            int workingDays = 0;
            DateTime curent = DateTime.Now;

            while (curent.Year != end.Year || curent.Month != end.Month || curent.Day != end.Day)
            {
                workingDays += CheckIfWorkDay(curent);
                workingDays += CheckIfWorkingSaturday(curent);

                curent = curent.AddDays(1);
            }

            return workingDays;
             
        }

        private static int CheckIfWorkDay(DateTime curent)
        {
            int workingDays = 0;
                        
            if (curent.DayOfWeek != DayOfWeek.Saturday && curent.DayOfWeek != DayOfWeek.Sunday)
            {
                workingDays++;

                foreach (DateTime holiday in holidays)
                {
                    if (curent.Month == holiday.Month && curent.Day == holiday.Day)
                    {
                        workingDays--;
                        break;
                    }
                }
            }

            return workingDays;
        }

        private static int CheckIfWorkingSaturday(DateTime curent)
        {
            int workingDays = 0;

            if (curent.DayOfWeek == DayOfWeek.Saturday)
            {
                foreach (DateTime saturday in workingSaturdays)
                {
                    DateTime possibleSaturday = new DateTime(curent.Year, saturday.Month, saturday.Day);

                    if (possibleSaturday.DayOfWeek == DayOfWeek.Saturday && curent.Day == possibleSaturday.Day && curent.Month == possibleSaturday.Month)
                    {
                        workingDays++;
                        break;
                    }
                }
            }

            return workingDays;
        }
    }
}
