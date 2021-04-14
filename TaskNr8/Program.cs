using System;

namespace TaskNr8
{
    class Program
    {
        static void Main(string[] args)
        {

            WeatherStation S1;
            S1.temp = 11;
            S1.wind = windSpeed.north;
            S1.date = Convert.ToDateTime("2021-04-14");
            S1.humidity = 2;
            S1.cloud = cloudCover.brak;

            Console.WriteLine(S1.ToString());

        }
    }
}
