using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace xaydunglopfan
{
    public class Fan
    {
        public const int SLOW = 1;
        public const int MEDIUM = 2;
        public const int FAST = 3;

        private int speed;
        private bool on;
        private double radius;
        private string color;

        public int Speed { get => speed; set => speed = value; }
        public bool On { get => on; set => on = value; }
        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }
        public override string ToString()
        {
            if (On)
            {
                return $"Speed: {Speed}, Color: {Color}, Radius: {Radius}, Fan is on";
            }
            else
            {
                return $"Color: {Color}, Radius: {Radius}, Fan is off";
            }
        }
    }
}
