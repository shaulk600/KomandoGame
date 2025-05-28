using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KomandoOOP;
using KomandoOOP.Commands;
using KomandoOOP.GameLogic;

namespace KomandoOOP.Enemies
{
    internal class EnemyFactory
    {
        /// <summary>
        ///  this Class is Factory
        /// </summary>

        // variable Singletone
        private static EnemyFactory instance = null;
        private static readonly object lockObj = new object();

        //variable 
        List<EnemySoldier> EnemySoldiers = new List<EnemySoldier>();//יצירת הליסט
        private static int NumberStaticOfCreate = 0;

        //Constractor Private
        private EnemyFactory() { }
            
        
        //GetInstance//
        public static EnemyFactory GetInstance()
        {
            //lock (lockObj)
            //{
                if (instance == null)
                {
                    instance = new EnemyFactory();

                }
            //}
            return instance;
        }
        public void BuildingList()
        {
            EnemyFactory.NumberStaticOfCreate++;
            //בשלב הזה אם צריך - לעשות swich
            string nameObjectCreate = "enemySoldier" + NumberStaticOfCreate;
            EnemySoldiers.Add(new EnemySoldier(nameObjectCreate));
        }

        // אופצייה של הוספת קוד דרך משתנים

        //private static async Task startCode()
        //{
        //    ////לפני הרצה - חובה התקנה של 
        //    ////Microsoft.CodeAnalysis.CSharp.Scripting

        //    //string code = "Console.WriteLine(\"שלום מהקוד הדינמי!\");";
        //    //await  CSharpScript.EvaluateAsync(code);
        //}
    }
}
