using System;

namespace ProjetoMat.Progression
{
    public static class Progreesions
    {
        public static List<double> GeometricProgression(double a, double r, int n)
        {
            List<double> result = new();
            double curr_term;

            for (int i = 0; i < n; i++)
            {
                curr_term = a * (double)Math.Pow(r, i);
                result.Add(curr_term);
            }

            return result;
        }

            //int a = 2;
            //int r = 3;
            //int n = 5;

    }
}
