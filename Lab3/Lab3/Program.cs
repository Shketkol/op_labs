using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num1 = 102;
            double num1Convert = num1;
            Console.WriteLine("byte " + num1 + " double " + num1Convert);

            long num2 = 1025879;
            short num2Convert = (short)num2;
            Console.WriteLine("long " + num2 + " short " + num2Convert);

            double num3 = -3.456;
            int num3Convert = (int)Convert.ChangeType(num3, TypeCode.Int32);
            Console.WriteLine("double " + num3 + " int " + num3Convert);

            bool num4Convert = Convert.ToBoolean(num3);
            Console.WriteLine("double " + num3 + " bool " + num4Convert);

            double num5 = 3.456;
            byte num5Convert = Convert.ToByte(num5);
            Console.WriteLine("double " + num5 + " byte " + num5Convert);

            byte num6 = 102;
            decimal num6Convert = Convert.ToDecimal(num6);
            Console.WriteLine("byte " + num6 + " demical " + num6Convert);

            decimal num7 = 101.1587M;
            double num7Convert = Convert.ToDouble(num7);
            Console.WriteLine("demical " + num7 + " double " + num7Convert);
        }
    }
}
