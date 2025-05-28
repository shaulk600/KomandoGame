using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KomandoOOP;
using KomandoOOP.Commands;
using KomandoOOP.Enemies;
using KomandoOOP.GameLogic;
using KomandoOOP.InterFaces;
using KomandoOOP.Testing;
using KomandoOOP.Weapons;

namespace KomandoOOP.Weapons
{
    internal class WeaponFactory : IBreakable , IShootable
    {
        /// <summary>
     ///  this Class is Factory
     /// </summary>

        // variable Singletone
        private static EnemyFactory instance = null;
        

        //variable 
        List<Weapon> Weapons = new List<Weapon>();//יצירת הליסט
        private static int NumberStaticOfCreate = 0;

        //Constractor Private
        private WeaponFactory() { }


        //GetInstance//
        public static EnemyFactory GetInstance()
        {
            
            if (instance == null)
            {
                instance = new WeaponFactory();

            }
            
            return instance;
        }
        public void BuildingList(string name, string manufacturer, int numberOfBalls)
        {
            WeaponFactory.NumberStaticOfCreate++;
            //בשלב הזה אם צריך - לעשות swich
            switch (name)
            {
                case "AK-47":
                    break;
                case "M-16":
                    break;
                default:
                    break;
            }
            string nameObjectCreate = "Weapon " + NumberStaticOfCreate;
            Weapons.Add(new Weapon(name, manufacturer, numberOfBalls));
        }
        public static void GetInterFace()
        {

        }
    }
}
