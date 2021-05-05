using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4317_DJR.Lib
{
    public class SemiConductor
    {
        public SemiConductor()
        {
            Substance_name = "";
            ForbiddenZone_width = "";
            Electron_move = "";
            Hole_move = "";
        }

        public string Substance_name { get; set; }
        public string ForbiddenZone_width { get; set; }
        public string Electron_move { get; set; }
        public string Hole_move { get; set; }
    }
}
