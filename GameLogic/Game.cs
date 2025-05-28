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
