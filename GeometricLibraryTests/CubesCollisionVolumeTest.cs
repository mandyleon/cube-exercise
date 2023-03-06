using GeometricLibrary;
using GeometricLibrary.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GeometricLibraryTests
{
    [TestClass]
    public class CubesCollisionVolumeTest
    {
        [TestMethod]
        public void VolumeCubesCollisionTrue()
        {
            CubeManager cm = new CubeManager();
            Cube cube1 = new Cube(2, new Point3D(2, 2, 4));
            Cube cube2 = new Cube(2, new Point3D(3, 2, 4));
            Assert.AreEqual(4,cm.CalculateVolumeIntercept(cube1,cube2));
        }

        [TestMethod]
        public void VolumeCubesCollisionFalse()
        {
            CubeManager cm = new CubeManager();
            Cube cube1 = new Cube(2, new Point3D(2, 2, 2));
            Cube cube2 = new Cube(3, new Point3D(1, 4, 10));
            Assert.AreEqual(-1,cm.CalculateVolumeIntercept(cube1, cube2));
        }
    }
}
