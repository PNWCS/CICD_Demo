namespace CICD_Core
{
    public class Calculator
    {
        public static double Divide(int a, int b)
        {

            if (b == 0) { throw new DivideByZeroException("Denominator cannot be 0"); }

            return (double)a/b;
        }

    }
}