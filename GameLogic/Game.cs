using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KomandoOOP;
using KomandoOOP.Commands;
using KomandoOOP.Enemies;


namespace KomandoOOP.GameLogic
{
    internal class Game
    {
        public static void Started()
        {
            CommandoFactory.GetInstance("vdx", "a");
        }
        
    }
}
