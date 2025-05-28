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
    internal class Commando
    {
        private string Name;
        public string NameCode { get; set; }
        
        public static List<string> Tools = new List<string> { "hammer", "chisel", "rope", "portfolio", "watery" };

        public static List<string> NameOfStatus = new List<string> { "standing", "going", "hiding" };
        private string Status = "";

        
        

        //Method
        public Commando(string name, string nameCode )
        {
            Name = name;
            NameCode = nameCode;
            Status = NameOfStatus[0];

            
        }

        public void Walk() 
        {
            Status = NameOfStatus[1];
            Console.WriteLine( Status );
        }
        public void Hide()
        {
            Status = NameOfStatus[2];
            Console.WriteLine(Status);
        }

        // ספציפית במקרה שבו אני מביא כמימוש אובייקט אחר כפרמטר
        // - במידה ואני יורש ממנו
        // אני חייב לדרוס את המתודה הנ"ל ולעשות עידכון לאובייקט הרלוונטי
        public virtual void Attack(Commando other) 
        {
            Console.WriteLine($"{other.NameCode} is attacked.");
        }
        public void GetStatus()
        {
            Console.WriteLine( $"{Name} is status {Status}");
        }
        public void SetStatus(string value)
        {
            if( NameOfStatus.Contains(value) )
            this.Status = value;
        }


        public string SayName(string commanderRank)
        {
            List<string> accaunt = new List<string> { "GENERAL", "COLONEL" };
            
            bool Flag = false;
            if (commanderRank.Equals(accaunt[0]) || (Flag == false ? true : false) && commanderRank.Equals(accaunt[1]))
            {
                return ValidationOfSayName(Flag);
            }
            return ("the information not Exsist - BM");
        }

        private string ValidationOfSayName(bool Flag)
        {
            if (Flag == true)
            {
                return NameCode;
            }
            return Name;
        }

        
    }
}
