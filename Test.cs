using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomandoOOP
{
    internal class Test
    {
        public static void start()
        {
            Commando soldierOne = new Commando("Toray y", "One scarecrow");
            Commando soldierTow = new Commando("Toray x", "Tow scarecrow");

            soldierOne.Walk();
            soldierOne.GetStatus();

            soldierTow.GetStatus();

            soldierOne.Hide();
            soldierOne.GetStatus();

            soldierOne.Attack(soldierTow);

            //בשביל הלמידה שהגדרנו במחלקת command נעשה פה:
            Console.WriteLine(soldierTow.NameCode);
            string a = "nn";
            soldierTow.NameCode = a;

            //Test from AirUNit
            AirCommando chiefPilot = new AirCommando("Kapten T", "Eagle first");
            AirCommando coPilot = new AirCommando("pilot S", "Eagle second");

            chiefPilot.GetStatus();
            coPilot.Attack(chiefPilot);

            //Test from SeaUnit

            SeaCommando assaultCommander = new SeaCommando("Kapten A", "Black shark kodkod");
            SeaCommando boatOperator = new SeaCommando("Kapten S", "Black whale kodkod");

            List<Commando> objj = new List<Commando> { soldierOne, soldierTow,  chiefPilot, coPilot,   assaultCommander, boatOperator }; //לצורך מימוש אפשר להשתמש ב OBJECT ואפשר להשתמש במימוש של האבא - מחלקת Commando
            
            for(int i = 0; i < (objj.Count - 1); i++)
            {
                //if ( objj[i].Equals(objj[i + 1]) ) //האם בtype לא פרימיטיבי בודק רק סוג type או גם ערך בפנים
                    
                if ((objj[i].GetType()) == (objj[i + 1].GetType()))
                {
                    objj[i].Attack(objj[i + 1]); 
                }
                else
                {
                    continue;
                }
                
            }
        }
    }
}
