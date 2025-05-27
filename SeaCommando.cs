using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomandoOOP
{
    internal class SeaCommando : Commando
    {
        public string unit = "from sea unit";

        public new static List<string> Tools = Commando.Tools.Concat(new List<string> { "hammer", "chisel", "rope", "portfolio", "watery", "sa'ar 6", "Kayak" }).ToList();
        public new static List<string> NameOfStatus = Commando.NameOfStatus.Concat(new List<string> { "standing", "going", "hiding", "swiming" }).ToList();
        public SeaCommando(string name, string nameCode) : base(name, nameCode)
        {
            name += unit;
        }
        public void Swim()
        {
            SetStatus(NameOfStatus[3]);
            GetStatus();
        }
        public override void Attack(Commando other)
        {
            Console.WriteLine($"{other.NameCode} is attacked.");
        }
    }
}
