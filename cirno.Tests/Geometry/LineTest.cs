﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using cirno;
using cirno.Geometry;
using static cirno.Tests.Geometry.GeometryTestHelper;

namespace cirno.Tests.Geometry {
    [TestClass]
    public class LineTest {
        [TestMethod]
        public void TestLineSide() {
            var line0 = L(0, 0, 1, 1);
            Assert.AreEqual(-1, line0.GetSideOf(V(0, 1)));
            Assert.AreEqual(0, line0.GetSideOf(V(0.5f, 0.5f)));
            Assert.AreEqual(1, line0.GetSideOf(V(1, 0)));

            var line1 = L(0, 0, 0, 3);
            Assert.AreEqual(-1, line1.GetSideOf(V(-1, -1)));
            Assert.AreEqual(0, line1.GetSideOf(V(0, 0)));
            Assert.AreEqual(1, line1.GetSideOf(V(1, 10)));
        }

        [TestMethod]
        public void TestLinePerpendicular() {
            var line0 = L(0, 0, 1, 1);
            Assert.AreEqual(V(0.5f, 0.5f), line0.GetPerpendicularFootOn(V(0, 1)));
            Assert.AreEqual(V(1, 0), line0.GetPerpendicular(V(0, 1)));
        }
    }
}
