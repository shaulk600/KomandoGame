using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomandoOOP.Weapons
{//אולי אינטר פייס אולי אבסטראקט נראה
    internal class Weapon
    {
        private string Name;
        private string Manufacturer; // שם יצרן
        private int NumberOfBalls;

        public Weapon(string name, string manufacturer, int numberOfBalls) 
        {
            Name = name;
            Manufacturer = manufacturer;
            NumberOfBalls = numberOfBalls;
        }
        public void shoot()
        {
            if(NumberOfBalls > 0) 
            {
                Console.WriteLine("shoot");
                NumberOfBalls--;
            }
            else
            {
                Console.WriteLine("Empty");
            }
            
        }
    }
}
