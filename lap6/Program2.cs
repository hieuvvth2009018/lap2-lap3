using System;

namespace lap6
{
    public class Program2
    {
        {
             void Main(string[] args)
            {
                Thermostat thermostat = new Thermostat();
                Heater Heater = new Heater(60);
                thermostat.OnTemperatureChange +=
                    Heater.OnTemperatureChanged;
                Heater heaterCuong = new Heater(100);
                thermostat.OnTemperatureChange += 
                    heaterCuong.OnTemperatureChanged;

                Cooler cooler = new Cooler(80);
                thermostat.OnTemperatureChange += 
                    cooler.OnTemperatureChanged;

                string temperature;
                Console.Write("Enter temperature: ");
                temperature = Console.ReadLine();
                thermostat.CurrentTemperature = int.Parse(temperature);
                Console.ReadLine();
            }
        }

    }
}