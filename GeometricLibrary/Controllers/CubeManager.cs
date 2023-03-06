using GeometricLibrary.Interfaces;
using GeometricLibrary.Services;

namespace GeometricLibrary
{
    public class CubeManager : ICubeManager
    {
        public double CalculateVolumeIntercept(ICube cube1, ICube cube2)
        {
            if(IsIntercept(cube1, cube2))
            {
                double valX = UtilHelper.GetOverlapDiff(cube1.GetAxisX1(), cube1.GetAxisX2(), cube2.GetAxisX1(), cube2.GetAxisX2());
                double valY = UtilHelper.GetOverlapDiff(cube1.GetAxisY1(), cube1.GetAxisY2(), cube2.GetAxisY1(), cube2.GetAxisY2());
                double valZ = UtilHelper.GetOverlapDiff(cube1.GetAxisZ1(), cube1.GetAxisZ2(), cube2.GetAxisZ1(), cube2.GetAxisZ2());
                return valX * valY * valZ;
            }
            return -1;
        }

        public bool IsIntercept(ICube cube1, ICube cube2)
        {
            return IsInterceptX(cube1, cube2) && IsInterceptY(cube1, cube2) && IsInterceptZ(cube1, cube2);
        }

        private bool IsInterceptX(ICube cube1, ICube cube2)
        {
            bool isXRange1 = UtilHelper.NumberBetween(cube1.GetAxisX1(), cube2.GetAxisX1(), cube2.GetAxisX2());
            bool isXRange2 = UtilHelper.NumberBetween(cube1.GetAxisX2(), cube2.GetAxisX1(), cube2.GetAxisX2());

            return isXRange1 || isXRange2;
        }

        private bool IsInterceptY(ICube cube1, ICube cube2)
        {
            bool isYRange1 = UtilHelper.NumberBetween(cube1.GetAxisY1(), cube2.GetAxisY1(), cube2.GetAxisY2());
            bool isYRange2 = UtilHelper.NumberBetween(cube1.GetAxisY2(), cube2.GetAxisY1(), cube2.GetAxisY2());

            return isYRange1 || isYRange2;
        }

        private bool IsInterceptZ(ICube cube1, ICube cube2)
        {
            bool isZRange1 = UtilHelper.NumberBetween(cube1.GetAxisZ1(), cube2.GetAxisZ1(), cube2.GetAxisZ2());
            bool isZRange2 = UtilHelper.NumberBetween(cube1.GetAxisZ2(), cube2.GetAxisZ1(), cube2.GetAxisZ2());

            return isZRange1 || isZRange2;
        }


    }
}
