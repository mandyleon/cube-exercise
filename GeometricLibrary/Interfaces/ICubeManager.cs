
using GeometricLibrary.Interfaces;

namespace GeometricLibrary
{
    public interface ICubeManager
    {
        /// <summary>
        /// In case of collide, calculate the insersected volume
        /// </summary>
        /// <param name="g1">Geometric1</param>
        /// <param name="g2">Geometric2</param>
        /// <returns>The insersected volume</returns>
        double CalculateVolumeIntercept(ICube g1, ICube g2);

        /// <summary>
        /// Calculate if two geometrics are collide
        /// </summary>
        /// <param name="g1">Geometric1</param>
        /// <param name="g2">Geometric2</param>
        /// <returns>True in case of collide</returns>
        bool IsIntercept(ICube g1, ICube g2);
    }
}
