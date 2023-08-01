using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N16_HT1
{
    internal class Spaceship
    {
        private float _fuel;
        private float _speed;
        private string _trajectory;

        public string Name { get; init; }
        public float Fuel => _fuel;
        public float Speed
        {
            get => _speed;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _speed = value;
                }
                else
                {
                    throw new Exception("Tezlik 0 va 100 oralig'ida bo'lishi kerak");
                }
            }
        }
        public string Trajectory
        {
            set
            {
                _trajectory = value;
            }
        }

        public Spaceship(string Name)
        {
            this.Name = Name;
            this._fuel = 100;
            this.Speed = 0;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nFuel: {Fuel}\nSpeed: {Speed}\nKutilayotgan trajectory: {_trajectory}";
        }

    }
}
