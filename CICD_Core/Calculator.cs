namespace CICD_Core
{
    public class Calculator
    {
        public static double Divide(int v1, int v2)
        {
            if (v2 == 0)
            {


                throw new NotImplementedException();
            }
            return v1 / v2;
        }
    }
}
