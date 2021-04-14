using System;
using System.Collections.Generic;
using System.Text;

namespace TaskNr8
{
    public enum windSpeed
    {

        west = 'W',
        south = 'S',
        east = 'E',
        north = 'N',

    }
    public enum cloudCover
    {

        duże = 'D',
        srednie = 'S',
        male = 'M',
        brak = 'B',

    }

    struct WeatherStation
    {
        

        public double temp;
        public DateTime date;
        public double humidity;
        public windSpeed wind;
        public cloudCover cloud;

        public WeatherStation(double temp, DateTime date, double humidity, windSpeed wind, cloudCover cloud)
        {
            this.cloud = cloud;
            this.wind = wind;
            this.temp = temp;
            this.date = date;
            this.humidity = humidity;
        }

        public override string ToString()
        {
            return $"Pomiar: {date}, Temperatura: {temp}, Kierunek wiatru: {wind}, Zachmurzenie {cloud}, Wilgotnosc {humidity}";
        }


    }
}
