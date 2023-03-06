using System;

namespace GeometricLibrary.Classes
{
    public class Geometric : IGeometric
    {
        protected Point3D center;

        public Geometric(Point3D center)
        {
            this.center = center;
        }
        public virtual double CalculateVolume()
        {
            throw new NotImplementedException();
        }
    }
}
