using GeometricLibrary;
using GeometricLibrary.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GeometricLibraryTests
{
    [TestClass]
    public class CubesCollisionTest
    {
        [TestMethod]
        public void CubesCollisionTrue()
        {
            CubeManager cm = new CubeManager();
            Cube cube1 = new Cube(2, new Point3D(2, 2, 2));
            Cube cube2 = new Cube(3, new Point3D(4, 4, 4));
            Assert.IsTrue(cm.IsIntercept(cube1,cube2));
        }

        [TestMethod]
        public void CubesCollisionFalseXAxis()
        {
            CubeManager cm = new CubeManager();
            Cube cube1 = new Cube(2, new Point3D(1, 4, 2));
            Cube cube2 = new Cube(3, new Point3D(10, 4, 2));
            Assert.IsFalse(cm.IsIntercept(cube1, cube2));
        }

        [TestMethod]
        public void CubesCollisionFalseYAxis()
        {
            CubeManager cm = new CubeManager();
            Cube cube1 = new Cube(2, new Point3D(1, 4, 2));
            Cube cube2 = new Cube(3, new Point3D(1, 40, 2));
            Assert.IsFalse(cm.IsIntercept(cube1, cube2));
        }

        [TestMethod]
        public void CubesCollisionFalseZAxis()
        {
            CubeManager cm = new CubeManager();
            Cube cube1 = new Cube(2, new Point3D(2, 2, 2));
            Cube cube2 = new Cube(3, new Point3D(1, 4, 10));
            Assert.IsFalse(cm.IsIntercept(cube1, cube2));
        }

        
    }
}
