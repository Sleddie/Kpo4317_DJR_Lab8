using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4317_DJR.Lib
{
    public class CreateTestData
    {
        public static List<SemiConductor> getSemiconductor()
        {
            List<SemiConductor> ScList = new List<SemiConductor>(3);
            {
                SemiConductor semiconductor = new SemiConductor()
                {
                    Substance_name = "Borum",
                    ForbiddenZone_width = "1.100",
                    Electron_move = "10",
                    Hole_move = "10"
                };
                ScList.Add(semiconductor);
            }
            {
                SemiConductor semiconductor = new SemiConductor()
                {
                    Substance_name = "Tellur",
                    ForbiddenZone_width = "0.360",
                    Electron_move = "1700",
                    Hole_move = "1200",
                };
                ScList.Add(semiconductor);
            }
            {
                SemiConductor semiconductor = new SemiConductor()
                {
                    Substance_name = "CdTe",
                    ForbiddenZone_width = "1.450",
                    Electron_move = "450",
                    Hole_move = "100",
                };
                ScList.Add(semiconductor);
            }
            return ScList;
        }
        public static void SetWhiteSpace(List<SemiConductor> _semiconductorList)
        {
            for (int i = 0; i < _semiconductorList.Count; i++)
            {
                SemiConductor semiconductor = _semiconductorList.ElementAt(i);
                int space = PositionDependentLoader.fieldsLength[0] - semiconductor.Substance_name.Length;
                semiconductor.Substance_name = string.Concat(Enumerable.Repeat(" ", space)) + semiconductor.Substance_name;
                space = PositionDependentLoader.fieldsLength[1] - semiconductor.ForbiddenZone_width.Length;
                semiconductor.ForbiddenZone_width = string.Concat(Enumerable.Repeat(" ", space)) + semiconductor.ForbiddenZone_width;
                space = PositionDependentLoader.fieldsLength[2] - semiconductor.Electron_move.Length;
                semiconductor.Electron_move = string.Concat(Enumerable.Repeat(" ", space)) + semiconductor.Electron_move;
                space = PositionDependentLoader.fieldsLength[3] - semiconductor.Hole_move.Length;
                semiconductor.Hole_move = string.Concat(Enumerable.Repeat(" ", space)) + semiconductor.Hole_move;
            }
        }
    }
}
