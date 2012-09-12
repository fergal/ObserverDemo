using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : IObserver,IDisplayElement                 
    {
        private float temperature;
	    private float humidity;
	    private ISubject WeatherData;

	
	public CurrentConditionsDisplay(ISubject weatherData)
	{
		this.WeatherData = weatherData;
		WeatherData.RegisterObserver(this);
	}

	public void DisplayWeatherStats()
	{
		Console.WriteLine("Current conditions: " + temperature + "F degrees and " + humidity + "% humidity");
	}

	public void Update(float temp, float humidity, float pressure)
	{
		this.temperature = temp;
		this.humidity = humidity;
		DisplayWeatherStats();

	}

    }
}
