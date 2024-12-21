using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLibraryV2.Models
{
    public class Enums
    {
        public enum GridSpotStatus
        {
            Empty,
            Ship,
            Miss,
            Hit,
            Sunk
        }
    }
}
