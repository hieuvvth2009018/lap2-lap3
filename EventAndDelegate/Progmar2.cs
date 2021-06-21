using System;
using Heater;
using Thermostat;

namespace progmar
{
    internal class Program2
    {
        {
            static void Main(string[] args)
            {
                thermostat thermostat = new thermostat();
                heater heater = new heater(60);
                thermostat.OnTemperatureChange +=
                    heater.OnTemperatureChanged;
                heater heaterCuong = new heater(100);
                thermostat.OnTemperatureChange +=
                    heaterCuong.OnTemperatureChanged;

                Cooler.Cooler cooler = new Cooler.Cooler(80);
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