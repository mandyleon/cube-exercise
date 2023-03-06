using GeometricLibrary.Classes;
using GeometricLibrary.Interfaces;

namespace GeometricLibrary
{
    public class Cube : Geometric, ICube
    {
        int dimension = 0;
        double distanceBorder = 0;

        public Cube(int dimension,Point3D center):base(center)
        {
            this.dimension = dimension;
            distanceBorder = ((double)dimension / 2);
        }

        public int GetDimension() { return dimension; }

        public override double CalculateVolume()
        {
            return dimension * dimension * dimension; 
        }

        public double GetAxisY1()
        {
            return center.Y - distanceBorder;
        }

        public double GetAxisY2()
        {
            return center.Y + distanceBorder;
        }

        public double GetAxisX1()
        {
            return center.X - distanceBorder;
        }

        public double GetAxisX2()
        {
            return center.X + distanceBorder;
        }

        public double GetAxisZ1()
        {
            return center.Z - distanceBorder;
        }

        public double GetAxisZ2()
        {
            return center.Z + distanceBorder;
        }
    }
}
