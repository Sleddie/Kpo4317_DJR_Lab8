using System.Collections.Generic;

namespace Kpo4317_DJR.Lib
{
    public class SemiconductorListTestLoader : ISemiconductorListLoader
    {
        public SemiconductorListTestLoader()
        {
            this._semiconductorList = new List<SemiConductor>();
        }

        private List<SemiConductor> _semiconductorList = null;
        private LoadStatus _status = LoadStatus.None;

        public List<SemiConductor> semiconductorList { get { return _semiconductorList; } }

        public LoadStatus status { get { return _status; } }

        public OnLoadFileDelegate LoadingRow { get; set; }

        public void Execute()
        {
            {
                SemiConductor semiconductor = new SemiConductor()
                {
                    Substance_name = "Borum",
                    ForbiddenZone_width = "1.100",
                    Electron_move = "10",
                    Hole_move = "10"
                };
                semiconductorList.Add(semiconductor);
            }
            {
                SemiConductor semiconductor = new SemiConductor()
                {
                    Substance_name = "Tellur",
                    ForbiddenZone_width = "0.360",
                    Electron_move = "1700",
                    Hole_move = "1200",
                };
                semiconductorList.Add(semiconductor);
            }
            {
                SemiConductor semiconductor = new SemiConductor()
                {
                    Substance_name = "CdTe",
                    ForbiddenZone_width = "1.450",
                    Electron_move = "450",
                    Hole_move = "100",
                };
                semiconductorList.Add(semiconductor);
            }
        }
    }
}
