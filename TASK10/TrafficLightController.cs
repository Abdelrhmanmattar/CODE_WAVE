using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY10
{
    public enum TrafficLight
    {
        Red = 0,
        Yellow,
        Green
    }
    public class TrafficLightController
    {
        public void DisplaySignal(TrafficLight light)
        {
            switch (light)
            {
                case TrafficLight.Red:
                    Console.WriteLine("Stop! The light is Red.");
                    break;
                case TrafficLight.Yellow:
                    Console.WriteLine("Caution! The light is Yellow.");
                    break;
                case TrafficLight.Green:
                    Console.WriteLine("Go! The light is Green.");
                    break;
                default:
                    Console.WriteLine("Invalid traffic light signal.");
                    break;
            }
        }
    }
}
