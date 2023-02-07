namespace LearnCSharp.Observer;

public class OldWeatherDataDesign
{
    public void MeasurementsChanged()
    {
        var temperature = GetTemperature();
        var humidity = GetHumidity();
        var pressure = GetPressure();

        // aaa.update(temperature, humidity, pressure);
        // bbb.update(temperature, humidity, pressure);
        // ccc.update(temperature, humidity, pressure);
    }
    
    private decimal GetPressure()
    {
        return 30m;
    }

    private decimal GetHumidity()
    {
        return 0.5m;
    }

    private decimal GetTemperature()
    {
        return 30.5m;
    }
}