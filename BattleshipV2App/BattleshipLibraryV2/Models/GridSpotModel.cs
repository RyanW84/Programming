using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BattleshipLibraryV2.Models
{
    public class GridSpotModel
    {
        public string? SpotLetter { get; set; }
        public int SpotNumber { get; set; }
        public Enums.GridSpotStatus Status { get; set; } = Enums.GridSpotStatus.Empty;
    }
}
