using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentsIntersection
{
    class AppointmentIntersection
    {
        static void Main(string[] args)
        {
            DateTime[] arrAppointments = new DateTime[] { new DateTime(2015, 11, 27, 15, 30, 00),
                                                            new DateTime(2015, 11, 27, 16, 15, 00)};
            TimeSpan[] arrDuration = new TimeSpan[] { new TimeSpan(2, 15, 0),
                                                        new TimeSpan(3, 0, 0)};

            FindIntersectingAppointments(arrAppointments, arrDuration);
        }

        static void FindIntersectingAppointments(DateTime[] startDates, TimeSpan[] durations)
        {
            TimeSpan intersection = new TimeSpan();
            for (int i = 0; i < startDates.Length; i++)
            {
                for (int j = i+1; j < startDates.Length; j++)
                {
                    if ((startDates[i].Add(durations[i]) > startDates[j]) && (startDates[i] < startDates[j].Add(durations[j])))
                    {
                        intersection = WhatsFirst(startDates, durations);
                        Console.WriteLine("The appointment starting at {0: dd/mm/yyyy hh:mm} intersects the appointment starting at {1: dd/mm/yyyy hh:mm} with exactly {2} minutes.", startDates[i], startDates[j], intersection.TotalMinutes);
                    }
                }
            }
        }

        static TimeSpan WhatsFirst(DateTime[]startDate, TimeSpan[] duration)
        {
            TimeSpan noIntersects = new TimeSpan(0, 0, 0);
            for (int i = 0; i < startDate.Length; i++)
            {
                for (int j = i+1; j < startDate.Length; j++)
                {
                    if (startDate[i] > startDate[j] && startDate[i].Add(duration[i]) < startDate[j].Add(duration[j]))
                    {
                        return startDate[j].Add(duration[j]) - startDate[i];
                    }

                    else if (startDate[i] < startDate[j] && startDate[i].Add(duration[i]) < startDate[j].Add(duration[j]))
                    {
                        return startDate[i].Add(duration[i]) - startDate[j];
                    }

                    else if (startDate[i] < startDate[j] && startDate[i].Add(duration[i]) < startDate[j].Add(duration[j]))
                    {
                        return duration[j];
                    }

                    else if (startDate[i] > startDate[j] && startDate[i].Add(duration[i]) > startDate[j].Add(duration[j]))
                    {
                        return duration[i];
                    }
                }
            }
            return noIntersects;
        }
    }
}
