using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Kpo4317_DJR.Lib;

namespace UnitTestProjectSemiconductor
{
    [TestClass]
    public class PositionDependentLoaderTest
    {
        [TestMethod]
        public void StringProccessingTest()
        {
            List<SemiConductor> original = CreateTestData.getSemiconductor();
            CreateTestData.SetWhiteSpace(original);
            for (int i = 0; i < original.Count; i++)
            {
                string line = "";
                line += original[i].Substance_name;
                line += original[i].ForbiddenZone_width;
                line += original[i].Electron_move;
                line += original[i].Hole_move;

                PositionDependentLoader pdLoader = new PositionDependentLoader();
                SemiConductor loaded = pdLoader.ObjectFromString(line);

                Assert.AreEqual(original[i].Substance_name, loaded.Substance_name);
                Assert.AreEqual(original[i].ForbiddenZone_width, loaded.ForbiddenZone_width);
                Assert.AreEqual(original[i].Electron_move, loaded.Electron_move);
                Assert.AreEqual(original[i].Hole_move, loaded.Hole_move);
            }
        }
    }
}
