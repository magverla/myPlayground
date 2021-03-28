using System;
using System.Collections.Generic;
using System.Text;

namespace PLAY.Taschenrechner.MitFloatRechnen
{
    public class CalcWithFloat
    {
        public CalcWithFloat()
        {

        }
        public void calcWithFloat()
        {
            Console.WriteLine("Erste Zahl");
            float a = stringToFloat(Console.ReadLine());
            Console.WriteLine("Zweite Zahl");
            float b = stringToFloat(Console.ReadLine());
            Console.WriteLine("Ergebnis: {0}", a + b);
        }

        float stringToFloat(string s)
        {
            try
            {
                return Convert.ToSingle(s);
            }catch (System.FormatException e)
            {
                return Convert.ToSingle(s.Replace('.', ','));
            }
            
        }
    }
}
