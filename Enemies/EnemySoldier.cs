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



namespace KomandoOOP.Enemies
{
    internal class EnemySoldier
    {
        //API
        /// <summary>
        /// 
        /// </summary>
        /// 
        
        //filed
        private string Name;
        private int Life = 100;
        public bool LifeStatus = true; //חי - 1 מת -0
        
        //constractor
        public EnemySoldier(string name)
        {
            if(name == null)
            {
                Name = "";
            }
            else
            {
                Name = name;
            }
                
        }
        //Mehods
        public void Shout()//צעקה
        {
            Console.WriteLine("i'm Enemy ! ");
        }

        public void LifeDownload()//הורד חיים
        {
            if (Life > 0)
            {
                Life--;
            }
            else
            {
                LifeStatus = false;
            }
        }


    }
}
