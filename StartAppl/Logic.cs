using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartAppl
{
    class Logic
    {
        public static string GetString(int i)
        {
            switch (i)
            {
                case 1: return "Не з'явився";
                case 2: return "Незадовільно";
                case 3: return "Задовільно";
                case 4: return "Добре";
                case 5: return "Відмінно";
                default: return "Неможлива ситуація";
            }
        }
    }
}
