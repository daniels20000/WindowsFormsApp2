using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace POSK
{
    [Serializable()]
    public class Rozkaz : ISerializable
    {
        public int operacja;
        public Rejestr arg1 = new Rejestr();
        public Object arg2 = new Object();

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("operacja", operacja);
            info.AddValue("arg1", arg1);
            info.AddValue("arg2", arg2);
           
        }
        public Rozkaz() { }

        public Rozkaz(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the properties
            operacja = (int)info.GetValue("operacja", typeof(int));
            arg1 = (Rejestr)info.GetValue("arg1", typeof(Rejestr));
            arg2 = (Object)info.GetValue("Height", typeof(Object));
        }

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
