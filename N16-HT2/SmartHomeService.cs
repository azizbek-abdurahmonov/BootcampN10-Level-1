using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N16_HT2
{
    internal class SmartHomeService
    {
        private bool _isActivated;
        private float _CurrentTemperature;
        private float _ExpectedTemperature;

        public bool IsActivated => _isActivated;
        public string DeviceName { get; init; }
        public float CurrentTemperature
        {
            set
            {
                if (value >= 0 && value <= 50)
                {
                    _CurrentTemperature = value;
                }
                else
                {
                    throw new Exception("Xarorat 0 va 50 orasida bo'lishi kerak!");
                }
            }
        }
        public float ExpectedTemperature
        {
            get
            {
                return _ExpectedTemperature;
            }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    _ExpectedTemperature = value;
                }
                else
                    throw new Exception("Xarorat 0 va 50 oralig'ida bo'lishi kerak!");
            }

        }

        List<Temperature> temperatures = new List<Temperature>();
        public void Add(Temperature temperature)
        {
            temperatures.Add(temperature);
        }

        public void Activate()
        {
            _isActivated = true;
        }

        public void DisplayHomeTemperature()
        {
            foreach (var temperature in temperatures)
            {
                Console.WriteLine($"Expected - {temperature.Expected}, Current - {temperature.Current}");
            }

        }
    }
}
