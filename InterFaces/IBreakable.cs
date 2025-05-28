using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomandoOOP.InterFaces
{
    internal interface IBreakable // שביר
    {
        string ShowStatus {  get; } // הצג את הסטטוס
        int NumberWeaponMax();  //   כמה כמות מכות מקסימלית
        string ShowNumberStrokes();  // הצג כמות מכות נוכחית
    }
}
