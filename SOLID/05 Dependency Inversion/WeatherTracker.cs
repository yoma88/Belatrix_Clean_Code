using System;

namespace SOLID._05_Dependency_Inversion
{
    public class WeatherTracker
    {
        String currentConditions;
        IGenerateWeatherAlert phone;
        IGenerateWeatherAlert emailer;

        public WeatherTracker()
        {
            phone = new Phone();
            emailer = new Emailer();
        }

        public void setCurrentConditions(String weatherDescription)
        {
            this.currentConditions = weatherDescription;
            if (weatherDescription == "rainy")
            {
                String alert = phone.generateWeatherAlert(weatherDescription);
                Console.WriteLine(alert);
            }
            if (weatherDescription == "sunny")
            {
                String alert = emailer.generateWeatherAlert(weatherDescription);
                Console.WriteLine(alert);
            }
        }
    }

    public interface IGenerateWeatherAlert
    {
        String generateWeatherAlert(String weatherConditions);        
    }
}
