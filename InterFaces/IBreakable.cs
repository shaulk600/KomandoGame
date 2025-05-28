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

namespace KomandoOOP.InterFaces
{
    internal interface IBreakable // שביר- אבן
    {
        bool IsHaveStatus(); // אם יש את הסטטוס
        bool IfLimitNumberBlows();  //   כמה כמות מכות מקסימלית
        int ShowNumberStrokes();  // הצג כמות מכות נוכחית-הדגש שכבר היו !!!
    }
}
