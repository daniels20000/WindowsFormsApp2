using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSK
{
    public class Rejestr
    {
        public byte NH;
        public byte NL;
        public Rejestr()
        {
            NH = 0;
            NL = 0;
        }
        public void setValue(int value)
        {
           byte[] bytes= BitConverter.GetBytes(value);
            NL=bytes[0];
            NH = bytes[1];
        }
        public Int16 getValue()
        {
            byte[] bytes = new byte[] { NL, NH };
            return BitConverter.ToInt16(bytes, 0);
        }
        public String getStringValue()
        {
            byte[] bytes = new byte[] { NL, NH };
            return Convert.ToString( BitConverter.ToInt16(bytes, 0),2).PadLeft(16,'0');
        }


    }
}
