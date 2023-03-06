using System;

namespace GeometricLibrary.Services
{
    public static class UtilHelper
    {
        public static bool NumberBetween(double search, double range1, double range2)
        {
            return search >= range1 && search <= range2;
        }

        public static double GetOverlapDiff(double x1, double x2, double x3, double x4)
        {
            if (Math.Max(x1, x2) <= Math.Min(x3, x4) || Math.Max(x3, x4) <= Math.Min(x1, x2))
            {
                return 0;
            }
            double start = Math.Max(x1, x3);
            double end = Math.Min(x2, x4);
            return end - start;
        }
    }
}
