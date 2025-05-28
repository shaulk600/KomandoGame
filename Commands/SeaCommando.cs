using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KomandoOOP;
using KomandoOOP.Enemies;
using KomandoOOP.GameLogic;


namespace KomandoOOP.Commands
{
    internal class SeaCommando : Commando
    {
        //public string unit = "from sea unit";

        public new static List<string> Tools = Commando.Tools.Concat(new List<string> { "hammer", "chisel", "rope", "portfolio", "watery", "sa'ar 6", "Kayak" }).ToList();
        public new static List<string> NameOfStatus = Commando.NameOfStatus.Concat(new List<string> { "standing", "going", "hiding", "swiming" }).ToList(); //יכול להיות שזה לא אובר רייד? - לבדוק
        public SeaCommando(string name, string nameCode) : base(name, nameCode)
        {
            //name += unit;
        }
        public void Swim()
        {
            string value = NameOfStatus[3];
            SetStatus(value);
            GetStatus();
        }
        public override void Attack(Commando other)
        {
            Console.WriteLine($"{other.NameCode} is attacked.");
        }
    }
}
