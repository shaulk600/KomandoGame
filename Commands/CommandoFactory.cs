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

namespace KomandoOOP.Commands
{
    internal class CommandoFactory
    {
        /// <summary>
        ///  this Class is Factory of Commando
        /// </summary>

        // variable Singletone
        private static CommandoFactory instance = null;

        //variable 
        List<Commando> EnemySoldiersCommando = new List<Commando>();//יצירת הליסט
        private static int NumberStaticOfCreate = 0;

        //Constractor Private
        private CommandoFactory(){ }
        //GetInstance//
        public static CommandoFactory GetInstance(string typeOfSoldier, string nameCode)
        {
            
            if (instance == null)
            {
                instance = new CommandoFactory();
            }
            return instance;
        }
        public void BuildingList(string typeOfSoldier, string nameCode)
        {

            CommandoFactory.NumberStaticOfCreate++;
            string nameObjectCreate = "Commando " + NumberStaticOfCreate;
            switch (typeOfSoldier)
            {
                case "air":
                    EnemySoldiersCommando.Add(new AirCommando(nameObjectCreate, nameCode));
                    break;
                case "sea":
                    EnemySoldiersCommando.Add(new SeaCommando(nameObjectCreate, nameCode));
                    break;

                default:
                    EnemySoldiersCommando.Add(new Commando(nameObjectCreate, nameCode));
                    break;
            }
        }
    }
}


