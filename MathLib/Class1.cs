namespace MathLib
{
    public class Culculation
    {
        public int Sum(int a, int b)
        {

            return a * b;
        }

        public int Factorial(int n)
        {
            if (n == 0) return 1;
            else return n*Factorial(n-1);
        }

    }
}
