using System;

namespace S3LabExam
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime sdate = Convert.ToDateTime("2019-08-31 08:59:13 am");
            DateTime edate = Convert.ToDateTime("2019-08-31 09:00:39 am");

            var result = CalculateBill(sdate, edate);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        public static double CalculateBill(DateTime start, DateTime end)
        {
            double result = 0;
            DateTime startTime = Convert.ToDateTime(start.ToString("h:mm:ss tt"));
            DateTime endTime = Convert.ToDateTime(end.ToString("h:mm:ss tt"));

            DateTime time1 = Convert.ToDateTime("9:00:00 am");
            DateTime time2 = Convert.ToDateTime("10:59:59 pm");

            DateTime time3 = Convert.ToDateTime("12:00:00 am");
            DateTime time4 = Convert.ToDateTime("8:59:59 am");

            DateTime time5 = Convert.ToDateTime("11:00:00 pm");
            DateTime time6 = Convert.ToDateTime("11:59:59 pm");

            while (startTime < endTime)
            {
                if (time1 < startTime && time2 >= startTime)
                {
                    startTime = startTime.AddSeconds(30);
                    result += 30;
                    startTime = startTime.AddSeconds(1);
                }
                if (time3 < startTime && time4 >= startTime)
                {
                    startTime = startTime.AddSeconds(20);
                    result += 20;
                    startTime = startTime.AddSeconds(1);
                }
                if (time5 < startTime && time6 >= startTime)
                {
                    startTime = startTime.AddSeconds(20);
                    result += 20;
                    startTime = startTime.AddSeconds(1);
                }

            }

            return result;
        }

    }
}
