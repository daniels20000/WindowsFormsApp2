using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSK
{
    public class Rozkaz
    {
        public int operacja;
        public Rejestr arg1 = new Rejestr();
        public Object arg2 = new Object();

        public String tekstRozkazu()
        {
            String rozkaz = "";
            String argument = "";
            switch (operacja)
            {
                case 0:
                    {
                        rozkaz = "MOV";
                    }break;
                case 1:
                    {
                        rozkaz = "ADD";
                    }
                    break;
                case 2:
                    {
                        rozkaz = "SUB";
                    }
                    break;
                default: { return "Operacja nieznana \r\n"; }

            }
            short i = 0;
            if (Int16.TryParse(arg2.ToString(), out i))
                argument = i.ToString();
            else
                argument = ((Rejestr)arg2).getNazwa();
            

            return rozkaz + "           " + arg1.getNazwa() + "           " + argument + "\r\n";
        }
    }
}
