using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KomandoOOP
{
    internal class AirCommando : Commando
    {
        //public string unit = "from air unit";
        
        public new static List<string> Tools = Commando.Tools.Concat(new List<string> { "hammer", "chisel", "rope", "portfolio", "watery" ,"zik", "F16"}).ToList();
        public new static List<string> NameOfStatus = Commando.NameOfStatus.Concat(new List<string> { "standing", "going", "hiding", "falling" }).ToList();
        public AirCommando(string name, string nameCode) : base (name,nameCode)
        {
            //name += unit;
        }
        public void OpenParachute()
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
