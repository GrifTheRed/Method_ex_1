using System;
namespace Methodex1
{
    public class Methods
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        internal static int Multiply(int v)
        {
            throw new NotImplementedException();
        }
    }
}

