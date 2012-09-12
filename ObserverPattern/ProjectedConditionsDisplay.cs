using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class ProjectedConditionsDisplay : IObserver,IDisplayElement
    {
        private float temperature;
	    private float humidity;
        private float pressure;
	    private ISubject weatherData;


    public ProjectedConditionsDisplay(ISubject weatherData)
	{
		this.weatherData = weatherData;
		weatherData.RegisterObserver(this);
	}

	public void DisplayWeatherStats()
	{
		Console.WriteLine("Projected conditions: " + temperature  + humidity + pressure);
	}

	public void Update(float temp, float humidity, float pressure)
	{
		this.temperature = temp;
		this.humidity = humidity;
	    this.pressure = pressure;
        if (humidity > 65)
        {
            DisplayWeatherStats();
        }

	}

    }
}

